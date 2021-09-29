using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonumentMlyn.DAL.Entities
{
    public class Customer
    {
        public Customer()
        {
            Monuments = new HashSet<Monument>();
        }

        public Customer(Guid idCustomer, string lastName, string surname, DateTime createUser, DateTime updateUser, string phone, string email, ICollection<Monument> monuments)
        {
            CustomerId = idCustomer;
            LastName = lastName;
            Surname = surname;
            CreateUser = createUser;
            UpdateUser = updateUser;
            Phone = phone;
            Email = email;
            Monuments = monuments;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; } 

        public string LastName { get; set; }

        public string Surname { get; set; }

        [Required] public DateTime CreateUser { get; set; }
        [Required] public DateTime UpdateUser { get; set; }

        [Required] public string Phone { get; set; }
        
         public string Email { get; set; }

         public virtual ICollection<Monument> Monuments { get; set; } = new List<Monument>();

    }
}
