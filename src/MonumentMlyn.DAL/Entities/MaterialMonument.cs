using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class MaterialMonument
    {
        [Key]
        public Guid IdMaterialMonument { get; set; }
        public Guid IdMonument { get; set; }
        public Guid IdMaterial { get; set; }

        public virtual Material IdMaterialNavigation { get; set; }
        public virtual Monument IdMonumentNavigation { get; set; }
    }
}
