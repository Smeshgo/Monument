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
        }
        [Key]
        public Guid IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }

        public List<Material> Materials { get; set; } = new List<Material>();
    }
}
