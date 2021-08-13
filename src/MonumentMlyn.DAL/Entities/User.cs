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

        public User(Guid idUser, string userNama, string password, string firstName, string lastName, string email, string status, DateTime? createUser, DateTime? updateUser)
        {
            IdUser = idUser;
            UserNama = userNama;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Status = status;
            CreateUser = createUser;
            UpdateUser = updateUser;    
        }
        [Key]
        public Guid IdUser { get; set; }
        public string UserNama { get; set; }
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
