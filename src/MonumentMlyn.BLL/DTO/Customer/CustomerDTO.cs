using System;
using System.ComponentModel.DataAnnotations;

namespace MonumentMlyn.BLL.DTO
{
    public class CustomerDto
    {
        public CustomerDto()
        {

        }

        public CustomerDto(Guid idCustomer, string lastName, string surname, DateTime createUser, DateTime updateUser, string phone, string email)
        {
            CustomerId = idCustomer;
            Last_name = lastName;
            Surname = surname;
            create_user = createUser;
            update_user = updateUser;
            Phone = phone;
            Email = email;
        }

        [Key]
        public Guid CustomerId { get; set; }

        public string Last_name { get; set; }

        public string Surname { get; set; }

        public DateTime create_user { get; set; }
        public DateTime update_user { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }


    }
}