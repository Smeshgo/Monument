using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MonumentMlyn.DAL.Entities
{
    public class Сustomer
    {
        public Сustomer()
        {
            Monuments = new HashSet<Monument>();
        }
        [Key]
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

        [Required] public string Email { get; set; }

        public virtual ICollection<Monument> Monuments { get; set; }

    }
}
