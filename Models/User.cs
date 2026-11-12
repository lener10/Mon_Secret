using System;
using System.Collections.Generic;
using System.Text;

namespace Mon_Secret.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
