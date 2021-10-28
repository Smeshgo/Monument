using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class User : IdentityUser
    {
        public User()
        {
        }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Article> Article { get; set; } = new List<Article>();

    }
}
