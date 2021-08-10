using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class RoleDTO
    {
        public RoleDTO()
        {
            UserRoles = new HashSet<UserRoleDTO>();
        }

        public Guid IdRole { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

        public virtual ICollection<UserRoleDTO> UserRoles { get; set; }
    }
}
