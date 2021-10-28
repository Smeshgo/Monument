using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MonumentMlyn.DAL.Enum;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Photo
    {
        public Photo()
        {
        }

        public Photo(Guid photoId, string name, byte[] fullPhoto, byte[] minyPhoto, DateTime? createPhoto, DateTime? updatePhoto, CategoryPhoto categoryPhoto, ICollection<Monument> monument, ICollection<Article> articles)
        {
            PhotoId = photoId;
            Name = name;
            FullPhoto = fullPhoto;
            MinyPhoto = minyPhoto;
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
            CategoryPhoto = categoryPhoto;
            Monument = monument;
            Articles = articles;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PhotoId { get; set; }
        public string Name { get; set; }
        public byte[] FullPhoto { get; set; }
        public byte[] MinyPhoto { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }
        public virtual ICollection<Monument> Monument { get; set; } = new List<Monument>();
        [JsonIgnore]
        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    }
}
