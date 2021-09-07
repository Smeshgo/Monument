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

        public PhotoDto(Guid idPhoto, string name, byte[] fullPhoto, byte[] minyPhoto, string categoryPhoto, DateTime? createPhoto, DateTime? updatePhoto)
        {
            IdPhoto = idPhoto;
            Name = name;
            FullPhoto = fullPhoto;
            MinyPhoto = minyPhoto;
            CategoryPhoto = categoryPhoto;
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
        }
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public byte[] FullPhoto { get; set; }
        public byte[] MinyPhoto { get; set; }
        public string CategoryPhoto { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }



    }
}
