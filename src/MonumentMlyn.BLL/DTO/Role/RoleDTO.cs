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
            RoleId = idRole;
            Name = name;
            Status = status;
            CreateRole = createRole;
            UpdateRole = updateRole;
        }
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

    }
}
