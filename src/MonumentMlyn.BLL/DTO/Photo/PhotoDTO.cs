using System;
using MonumentMlyn.DAL.Enum;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoDto
    {
        public PhotoDto()
        {
        }

        public PhotoDto(Guid idPhoto, string name, string pathFull, string pathMini, string uuid, CategoryPhoto categoryPhoto, DateTime? createPhoto, DateTime? updatePhoto)
        {
            IdPhoto = idPhoto;
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            Uuid = uuid;
            CategoryPhoto = categoryPhoto.ToString();
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
        }
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }
        public string CategoryPhoto { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }



    }
}
