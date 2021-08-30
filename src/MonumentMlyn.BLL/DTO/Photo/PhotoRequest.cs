using System;

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoRequest
    {
        public PhotoRequest()
        {
            
        }

        public PhotoRequest(string name, string pathFull, string pathMini, string uuid, Guid idCategoryPhoto, CategoryPhotoDto categoryPhoto)
        {
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            Uuid = uuid;
            IdCategoryPhoto = idCategoryPhoto;
            CategoryPhoto = categoryPhoto;
        }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }

        public Guid IdCategoryPhoto { get; set; }

        public CategoryPhotoDto CategoryPhoto { get; set; }
    }
}