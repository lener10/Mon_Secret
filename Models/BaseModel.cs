
using Mon_Secret.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Mon_Secret.Models
{
    internal abstract class BaseModel<T> : Db where T : class, new()
    {
        protected string table;

        public BaseModel(string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentException("Le nom de la table est obligatoire.");

            VerifierIdentifiant(tableName);
            table = tableName;
        }

        private static void VerifierIdentifiant(string nom)
        {
            if (!Regex.IsMatch(nom, @"^[A-Za-z_][A-Za-z0-9_]*$"))
                throw new ArgumentException("Nom SQL invalide : " + nom);
        }

        private PropertyInfo[] GetProperties()
        {
            return typeof(T).GetProperties()
                .Where(p =>
                    p.CanRead &&
                    p.CanWrite &&
                    p.GetIndexParameters().Length == 0 &&
                    !Attribute.IsDefined(p, typeof(NotMappedAttribute)))
                .ToArray();
        }

        private string GetColumnName(PropertyInfo property)
        {
            var attribute = property.GetCustomAttribute<ColumnAttribute>();

            string columnName =
                attribute?.Name ?? property.Name.ToLowerInvariant();

            VerifierIdentifiant(columnName);
            return columnName;
        }

        // 1. SAVE
        public bool Save(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var properties = GetProperties()
                .Where(p => p.Name.ToLowerInvariant() != "id")
                .ToArray();

            if (properties.Length == 0)
                throw new InvalidOperationException("Aucune propriété à enregistrer.");

            var columns = properties
                .Select(p => $"`{GetColumnName(p)}`")
                .ToList();

            var values = new List<string>();

            for (int i = 0; i < properties.Length; i++)
                values.Add($"@p{i}");

            string sql = $"INSERT INTO `{table}` " +
                         $"({string.Join(", ", columns)}) VALUES (" +
                         $"{string.Join(", ", values)})";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    for (int i = 0; i < properties.Length; i++)
                    {
                        object? value = properties[i].GetValue(entity);

                        cmd.Parameters.AddWithValue(
                            $"@p{i}",
                            value ?? DBNull.Value
                        );
                    }

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 2. FIND ALL
        public DataTable FindAll()
        {
            return ExecuterSelect($"SELECT * FROM `{table}`");
        }

        // 3. FIND ALL DESC
        public DataTable FindAllDesc()
        {
            return ExecuterSelect(
                $"SELECT * FROM `{table}` ORDER BY `id` DESC"
            );
        }

        private DataTable ExecuterSelect(string sql)
        {
            DataTable dt = new DataTable();

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // 4. UPDATE
        public bool Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            PropertyInfo? propId = typeof(T).GetProperty("Id");

            if (propId == null)
                throw new InvalidOperationException(
                    "La propriété Id est obligatoire pour modifier."
                );

            object? id = propId.GetValue(entity);

            if (id == null)
                throw new InvalidOperationException("Identifiant invalide.");

            var properties = GetProperties()
                .Where(p => p.Name.ToLowerInvariant() != "id")
                .ToArray();

            if (properties.Length == 0)
                throw new InvalidOperationException("Aucune propriété à modifier.");

            var setClause = new List<string>();

            for (int i = 0; i < properties.Length; i++)
            {
                setClause.Add(
                    $"`{GetColumnName(properties[i])}` = @p{i}"
                );
            }

            string sql = $"UPDATE `{table}` SET " +
                         $"{string.Join(", ", setClause)} WHERE `id` = @id";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    for (int i = 0; i < properties.Length; i++)
                    {
                        object? value = properties[i].GetValue(entity);

                        cmd.Parameters.AddWithValue(
                            $"@p{i}",
                            value ?? DBNull.Value
                        );
                    }

                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 5. DELETE BY ID
        public bool DeleteById(int id)
        {
            string sql = $"DELETE FROM `{table}` WHERE `id` = @id";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            PropertyInfo? propId = typeof(T).GetProperty("Id");

            if (propId == null)
                throw new InvalidOperationException("Propriété Id introuvable.");

            object? id = propId.GetValue(entity);

            if (id == null)
                return false;

            return DeleteById(Convert.ToInt32(id));
        }

        // 6. FIND BY ID
        public T? FindById(int id)
        {
            string sql = $"SELECT * FROM `{table}` WHERE `id` = @id LIMIT 1";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        T entity = new T();

                        foreach (var property in GetProperties())
                        {
                            string column = GetColumnName(property);

                            int index;

                            try
                            {
                                index = reader.GetOrdinal(column);
                            }
                            catch (IndexOutOfRangeException)
                            {
                                continue;
                            }

                            if (reader.IsDBNull(index))
                                continue;

                            object value = reader.GetValue(index);

                            Type targetType =
                                Nullable.GetUnderlyingType(property.PropertyType)
                                ?? property.PropertyType;

                            if (targetType.IsEnum)
                            {
                                value = Enum.ToObject(targetType, value);
                            }
                            else if (targetType != value.GetType())
                            {
                                value = Convert.ChangeType(value, targetType);
                            }

                            property.SetValue(entity, value);
                        }

                        return entity;
                    }
                }
            }
        }

        // 7. FIND BY AND
        public DataTable FindBy(
            List<string>? listKey = null,
            Dictionary<string, object?>? conditions = null)
        {
            return FindByCondition(listKey, conditions, "AND");
        }

        // 8. FIND BY OR
        public DataTable FindByOr(
            List<string>? listKey = null,
            Dictionary<string, object?>? conditions = null)
        {
            return FindByCondition(listKey, conditions, "OR");
        }

        private DataTable FindByCondition(
            List<string>? listKey,
            Dictionary<string, object?>? conditions,
            string operateur)
        {
            listKey ??= new List<string>();
            conditions ??= new Dictionary<string, object?>();

            string columns;

            if (listKey.Count == 0)
            {
                columns = "*";
            }
            else
            {
                foreach (string column in listKey)
                    VerifierIdentifiant(column);

                columns = string.Join(
                    ", ",
                    listKey.Select(c => $"`{c}`")
                );
            }

            string where = "1 = 1";

            if (conditions.Count > 0)
            {
                var clauses = new List<string>();
                int index = 0;

                foreach (var condition in conditions)
                {
                    VerifierIdentifiant(condition.Key);
                    clauses.Add($"`{condition.Key}` = @p{index}");
                    index++;
                }

                where = string.Join($" {operateur} ", clauses);
            }

            string sql = $"SELECT {columns} FROM `{table}` WHERE {where}";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    int index = 0;

                    foreach (var condition in conditions)
                    {
                        cmd.Parameters.AddWithValue(
                            $"@p{index}",
                            condition.Value ?? DBNull.Value
                        );

                        index++;
                    }

                    DataTable dt = new DataTable();

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    return dt;
                }
            }
        }

        // 9. SEARCH
        public DataTable Search(
            string query,
            params string[] searchableProperties)
        {
            DataTable dt = new DataTable();

            if (string.IsNullOrWhiteSpace(query))
                return FindAll();

            PropertyInfo[] properties = GetProperties();

            if (searchableProperties == null ||
                searchableProperties.Length == 0)
            {
                properties = properties
                    .Where(p => p.PropertyType == typeof(string))
                    .ToArray();
            }
            else
            {
                properties = searchableProperties
                    .Select(name => properties.FirstOrDefault(
                        p => p.Name.Equals(
                            name,
                            StringComparison.OrdinalIgnoreCase
                        )
                    ))
                    .OfType<PropertyInfo>()
                    .ToArray();

                if (properties.Length == 0)
                    throw new ArgumentException(
                        "Aucune propriété de recherche valide."
                    );

                if (properties.Any(p => p.PropertyType != typeof(string)))
                    throw new ArgumentException(
                        "La recherche est réservée aux propriétés de type string."
                    );
            }

            if (properties.Length == 0)
                return dt;

            var clauses = new List<string>();

            for (int i = 0; i < properties.Length; i++)
            {
                clauses.Add(
                    $"`{GetColumnName(properties[i])}` LIKE @p{i}"
                );
            }

            string sql = $"SELECT * FROM `{table}` WHERE " +
                         string.Join(" OR ", clauses);

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    for (int i = 0; i < properties.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(
                            $"@p{i}",
                            $"%{query}%"
                        );
                    }

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
