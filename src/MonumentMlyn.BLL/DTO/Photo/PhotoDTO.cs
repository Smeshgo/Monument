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

        public PhotoDto(Guid photoId, string name, byte[] fullPhoto, byte[] minyPhoto, DateTime? createPhoto, DateTime? updatePhoto, CategoryPhoto categoryPhoto)
        {
            PhotoId = photoId;
            Name = name;
            FullPhoto = fullPhoto;
            MinyPhoto = minyPhoto;
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
            CategoryPhoto = categoryPhoto;
        }
        public Guid PhotoId { get; set; }
        public string Name { get; set; }
        public byte[] FullPhoto { get; set; }
        public byte[] MinyPhoto { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }
      



    }
}
