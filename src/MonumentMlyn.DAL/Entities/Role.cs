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

        public Role(Guid idRole, string name, string status, DateTime? createRole, DateTime? updateRole)
        {
            IdRole = idRole;
            Name = name;
            Status = status;
            CreateRole = createRole;
            UpdateRole = updateRole;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRole { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
