using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Role
    {
        public Role()
        {
            
        }

        public Role(Guid roleId, string name, string status, DateTime? createRole, DateTime? updateRole, ICollection<User> roleUsers)
        {
            RoleId = roleId;
            Name = name;
            Status = status;
            CreateRole = createRole;
            UpdateRole = updateRole;
            RoleUsers = roleUsers;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

        public virtual ICollection<User> RoleUsers { get; set; } = new List<User>();


        //public List<User> Users { get; set; } = new List<User>();
    }
}
