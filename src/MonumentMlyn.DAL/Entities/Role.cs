﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Role
    {
        public Role()
        {
            
        }
        [Key]
        public Guid IdRole { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreateRole { get; set; }
        public DateTime? UpdateRole { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
