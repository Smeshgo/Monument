using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class CategoryPhotoDto
    {
        private CategoryPhotoDto()
        {

        }

        public CategoryPhotoDto(Guid idCategoryPhoto, string name, DateTime createPhotoPhoto, DateTime updateCategoryPhoto)
        {
            this.IdCategoryPhoto = idCategoryPhoto;
            this.Name = name;
            this.CreatePhotoPhoto = createPhotoPhoto;
            this.UpdateCategoryPhoto = updateCategoryPhoto;
        }
        public Guid IdCategoryPhoto { get; set; }
        public string Name { get; set; }
        public DateTime? CreatePhotoPhoto { get; set; }
        public DateTime? UpdateCategoryPhoto { get; set; }
    }
}
