using System;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class UserDto : IdentityUser
    {
        public UserDto()
        {
        }

        public UserDto(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
 
    }
}
