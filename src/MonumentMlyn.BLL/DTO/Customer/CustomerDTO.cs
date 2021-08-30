using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.DTO
{
    public class CustomerDto
    {
        public CustomerDto()
        {
            
        }

        public CustomerDto(Guid idCustomer, string lastName, string surname, DateTime createUser, DateTime updateUser, string phone, string email)
        {
            IdCustomer = idCustomer;
            LastName = lastName;
            Surname = surname;
            CreateUser = createUser;
            UpdateUser = updateUser;
            Phone = phone;
            Email = email;
        }

        [Key]
        public Guid IdCustomer { get; set; }

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string LastName { get; set; }

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string Surname { get; set; }

        [Required] public DateTime CreateUser { get; set; }
        [Required] public DateTime UpdateUser { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required] public string Phone { get; set; }

        [Required] public string Email { get; set; }

        
    }
}