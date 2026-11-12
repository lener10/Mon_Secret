using System.ComponentModel.DataAnnotations.Schema;

namespace Mon_Secret.Models
{
    internal class Contact
    {
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        public string Nom { get; set; } = string.Empty;

        public string Prenom { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Adresse { get; set; } = string.Empty;
    }
}
