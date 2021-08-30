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

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string Last_name { get; set; }

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string Surname { get; set; }

        [Required] public DateTime create_user { get; set; }
        [Required] public DateTime update_user { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required] public string Phone { get; set; }
        
         public string Email { get; set; }

        public virtual ICollection<Monument> Monuments { get; set; }

    }
}
