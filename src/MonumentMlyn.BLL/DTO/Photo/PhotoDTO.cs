using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoDto
    {
        public PhotoDto()
        {
        }
        public PhotoDto(Guid idPhoto, string name, string pathFull, string pathMini, string uuid,
            DateTime? createPhoto, DateTime? updatePhoto, Guid idCategoryPhoto, CategoryPhotoDto categoryPhoto)
        {
            this.IdPhoto = idPhoto;
            this.Name = name;
            this.PathFull = pathFull;
            this.PathMini = pathMini;
            this.Uuid = uuid;
            this.CreatePhoto = createPhoto;
            this.UpdatePhoto = updatePhoto;
            this.IdCategoryPhoto = idCategoryPhoto;
            this.CategoryPhoto = categoryPhoto;
        }
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public Guid IdCategoryPhoto { get; set; }

        public CategoryPhotoDto CategoryPhoto { get; set; }

    }
}
