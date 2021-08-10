using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class User
    {
        public User()
        {
        }
        [Key]
        public Guid IdUser { get; set; }
        public string Usernama { get; set; }
        public string Password { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? CreateUser { get; set; }
        public DateTime? UpdateUser { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();
        public List<Role> Roles { get; set; } = new List<Role>();
    }
}
