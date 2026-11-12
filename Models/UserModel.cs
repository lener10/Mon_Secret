
using Mon_Secret.Core;
using MySql.Data.MySqlClient;
using System;

namespace Mon_Secret.Models
{
    internal class UserModel : Db
    {
        public UserModel()
        {
            CreateTable();
        }

        private void CreateTable()
        {
            string sql = @"
                CREATE TABLE IF NOT EXISTS users (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    fullname VARCHAR(100) NOT NULL,
                    username VARCHAR(50) NOT NULL UNIQUE,
                    password_hash VARCHAR(255) NOT NULL,
                    pin_hash VARCHAR(255) NOT NULL,
                   created_at DATETIME DEFAULT CURRENT_TIMESTAMP
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

        public bool HasUser()
        {
            string sql = "SELECT COUNT(*) FROM users";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool Save(User user)
        {
            string sql = @"
                INSERT INTO users
                (fullname, username, password_hash, pin_hash)
                VALUES
                (@fullname, @username, @password, @pin)";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fullname", user.Fullname);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@pin", user.Pin);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



        public User FindByUsername(string username)
        {
            string sql = @"
        SELECT id, fullname, username,
               password_hash, pin_hash, created_at
        FROM users
        WHERE username = @username
        LIMIT 1";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Fullname = reader["fullname"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["password_hash"].ToString(),
                                Pin = reader["pin_hash"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["created_at"])
                            };
                        }
                    }
                }
            }

            return null;
        }
        public User FindById(int id)
        {
            string sql = @"
        SELECT id, fullname, username, password_hash, pin_hash, created_at
        FROM users
        WHERE id = @id
        LIMIT 1";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Fullname = reader["fullname"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["password_hash"].ToString(),
                                Pin = reader["pin_hash"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["created_at"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool UpdatePassword(int userId, string passwordHash)
        {
            string sql = @"
        UPDATE users
        SET password_hash = @password
        WHERE id = @id";

            using (var conn = MySqlConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    cmd.Parameters.AddWithValue("@id", userId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
