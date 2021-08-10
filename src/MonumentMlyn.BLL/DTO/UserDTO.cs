using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class UserDTO
    {
        public UserDTO()
        {
            ArticleUsers = new HashSet<ArticleUserDTO>();
            UserRoles = new HashSet<UserRoleDTO>();
        }

        public Guid IdUser { get; set; }
        public string Usernama { get; set; }
        public string Password { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? CreateUser { get; set; }
        public DateTime? UpdateUser { get; set; }

        public virtual ICollection<ArticleUserDTO> ArticleUsers { get; set; }
        public virtual ICollection<UserRoleDTO> UserRoles { get; set; }
    }
}
