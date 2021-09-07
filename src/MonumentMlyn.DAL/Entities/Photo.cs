using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MonumentMlyn.DAL.Enum;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Photo
    {
        public Photo()
        {
        }

        public Photo(Guid idPhoto, string name, byte[] fullPhoto, byte[] minyPhoto, DateTime? createPhoto, DateTime? updatePhoto, CategoryPhoto categoryPhoto)
        {
            IdPhoto = idPhoto;
            Name = name;
            FullPhoto = fullPhoto;
            MinyPhoto = minyPhoto;
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
            CategoryPhoto = categoryPhoto;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public byte[] FullPhoto { get; set; }
        public byte[] MinyPhoto { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }

        public List<Monument> Monuments { get; set; } = new List<Monument>();
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
