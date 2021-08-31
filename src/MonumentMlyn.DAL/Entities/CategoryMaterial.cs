using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class CategoryMaterial
    {
        public CategoryMaterial()
        {
        }

        public CategoryMaterial(Guid idCategoryMaterial, string name, DateTime? createCategoryMaterial, DateTime? updateCategoryMaterial)
        {
            IdCategoryMaterial = idCategoryMaterial;
            Name = name;
            CreateCategoryMaterial = createCategoryMaterial;
            UpdateCategoryMaterial = updateCategoryMaterial;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }
        public DateTime? UpdateCategoryMaterial { get; set; }


        
    }
}
