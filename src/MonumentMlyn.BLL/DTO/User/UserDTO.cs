using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class UserDto
    {
        public UserDto()
        {
        }

        public UserDto(Guid idUser, string userNama, string password, string firstName, 
            string lastName, string email, string status, DateTime? createUser, DateTime? updateUser)
        {
            UserId = idUser;
            UserName = userNama;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Status = status;
            CreateUser = createUser;
            UpdateUser = updateUser;
        }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? CreateUser { get; set; }
        public DateTime? UpdateUser { get; set; }
    }
}
