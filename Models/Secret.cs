using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mon_Secret.Models
{
    internal class Secret
    {
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Column("secret_value")]
        public string SecretValue { get; set; } = string.Empty;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}