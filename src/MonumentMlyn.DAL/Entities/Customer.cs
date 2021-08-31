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
            id_customer = idCustomer;
            Last_name = lastName;
            Surname = surname;
            create_user = createUser;
            update_user = updateUser;
            Phone = phone;
            Email = email;
            Monuments = monuments;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id_customer { get; set; } 

        public string Last_name { get; set; }

        public string Surname { get; set; }

        [Required] public DateTime create_user { get; set; }
        [Required] public DateTime update_user { get; set; }

        [Required] public string Phone { get; set; }
        
         public string Email { get; set; }

        public virtual ICollection<Monument> Monuments { get; set; }

    }
}
