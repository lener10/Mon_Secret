using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mon_Secret.Core
{
    internal class Db
    {
   
            private string db_name = "Mon_Secret";
            private string db_host = "localhost";
            private string db_user = "root";
            private string db_pass = "";
            private string db_port = "3306";

            public Db()
            {
                CreateDatabase();
            }

            private void CreateDatabase()
            {
                string strconn = $"Server={db_host};Uid={db_user};Pwd={db_pass};Port={db_port};";

                using (var conn = new MySqlConnection(strconn))
                {
                    try
                    {
                        conn.Open();

                        string sql = $"CREATE DATABASE IF NOT EXISTS `{db_name}`";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception(
                            "Erreur lors de la création de la base de données : "
                            + ex.Message
                        );
                    }
                }
            }

            protected MySqlConnection MySqlConnection()
            {
                string strconn =
                    $"Server={db_host};Uid={db_user};Pwd={db_pass};Port={db_port};Database={db_name};";

                return new MySqlConnection(strconn);
            }
        }

    }
