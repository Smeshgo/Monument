using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class CategoryMaterialDto
    {
        public CategoryMaterialDto()
        {
        }
        public CategoryMaterialDto(Guid idCategoryMaterial, string name, DateTime? createCategoryMaterial)
        {
            this.IdCategoryMaterial = idCategoryMaterial;
            this.Name = name;
            this.CreateCategoryMaterial = createCategoryMaterial;
        }
        public Guid IdCategoryMaterial { get; set; }
        public string Name { get; set; }
        public DateTime? CreateCategoryMaterial { get; set; }
    }
}
