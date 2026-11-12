using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Mon_Secret.Models
{
    internal class SecretModel : BaseModel<Secret>
    {
        public SecretModel() : base("secrets")
        {
            CreateTable();
        }

        // =========================================
        // CREATION DE LA TABLE
        // =========================================

        private void CreateTable()
        {
            string sql = @"
                CREATE TABLE IF NOT EXISTS secrets (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    user_id INT NOT NULL,
                    title VARCHAR(100) NOT NULL,
                    category VARCHAR(50) NOT NULL,
                    description TEXT NULL,
                    secret_value LONGTEXT NOT NULL,
                    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,

                    CONSTRAINT fk_secret_user
                    FOREIGN KEY (user_id)
                    REFERENCES users(id)
                    ON DELETE CASCADE
                ) ENGINE=InnoDB;
            ";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =========================================
        // AFFICHER LES SECRETS D'UN UTILISATEUR
        // =========================================

        public DataTable FindAllByUserId(int userId)
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT id, title, category, description, created_at
                FROM secrets
                WHERE user_id = @userId
                ORDER BY id DESC;
            ";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // =========================================
        // RECHERCHER UN SECRET APPARTENANT A UN UTILISATEUR
        // =========================================

        public DataTable FindSecretById(int secretId, int userId)
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT *
                FROM secrets
                WHERE id = @secretId
                AND user_id = @userId
                LIMIT 1;
            ";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@secretId", secretId);
                    cmd.Parameters.AddWithValue("@userId", userId);

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
