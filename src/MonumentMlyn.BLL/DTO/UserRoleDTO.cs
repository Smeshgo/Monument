using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class UserRoleDTO
    {
        public Guid IdRole { get; set; }
        public Guid IdUser { get; set; }

        public virtual RoleDTO IdRoleNavigation { get; set; }
        public virtual UserDTO IdUserNavigation { get; set; }
    }
}
