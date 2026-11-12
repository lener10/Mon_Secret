using System.Data;
using MySql.Data.MySqlClient;

namespace Mon_Secret.Models
{
    internal class ContactModel : BaseModel<Contact>
    {
        public ContactModel() : base("contacts")
        {
            CreateTable();
        }

        private void CreateTable()
        {
            const string sql = @"
                CREATE TABLE IF NOT EXISTS contacts (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    user_id INT NOT NULL,
                    nom VARCHAR(100) NOT NULL,
                    prenom VARCHAR(100) NOT NULL,
                    telephone VARCHAR(30) NOT NULL,
                    email VARCHAR(254) NOT NULL,
                    adresse VARCHAR(255) NOT NULL,

                    CONSTRAINT fk_contact_user
                    FOREIGN KEY (user_id)
                    REFERENCES users(id)
                    ON DELETE CASCADE
                ) ENGINE=InnoDB;
            ";

            using var conn = MySqlConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public DataTable FindAllByUserId(int userId)
        {
            const string sql = @"
                SELECT id, nom, prenom, telephone, email, adresse
                FROM contacts
                WHERE user_id = @userId
                ORDER BY nom, prenom, id DESC;
            ";

            return ExecuterRequete(sql, userId);
        }

        public DataTable FindContactById(int contactId, int userId)
        {
            const string sql = @"
                SELECT *
                FROM contacts
                WHERE id = @contactId AND user_id = @userId
                LIMIT 1;
            ";

            return ExecuterRequete(sql, userId, contactId);
        }

        private DataTable ExecuterRequete(string sql, int userId, int? contactId = null)
        {
            DataTable table = new DataTable();

            using var conn = MySqlConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", userId);

            if (contactId.HasValue)
                cmd.Parameters.AddWithValue("@contactId", contactId.Value);

            using var adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
