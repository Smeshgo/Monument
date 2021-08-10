using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class CategoryMaterial
    {
        public CategoryMaterial()
        {
            Materials = new HashSet<Material>();
        }
        [Key]
        public Guid IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
