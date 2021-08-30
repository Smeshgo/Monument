using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class RoleDto
    {
        public RoleDto()
        {
            
        }
        public RoleDto(Guid idRole, string name, string status, DateTime? createRole, DateTime? updateRole)
        {
            this.IdRole = idRole;
            this.Status = status;
            this.CreateRole = createRole;
            this.UpdateRole = updateRole;
        }
        public Guid IdRole { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

    }
}
