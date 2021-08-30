using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class User
    {
        public User()
        {
        }

        public User(Guid idUser, string userNama, string password, string firstName, string lastName, string email, string status, DateTime? createUser, DateTime? updateUser)
        {
            IdUser = idUser;
            UserName = userNama;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Status = status;
            CreateUser = createUser;
            UpdateUser = updateUser;    
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
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
