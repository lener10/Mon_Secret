using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mon_Secret.Models
{
    internal class Activite
    {
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Column("date_heure")]
        public DateTime DateHeure { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}
