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

        public Photo(Guid idPhoto, string name, string pathFull, string pathMini, string uuid, DateTime? createPhoto, DateTime? updatePhoto, CategoryPhoto categoryPhoto)
        {
            IdPhoto = idPhoto;
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            Uuid = uuid;
            CreatePhoto = createPhoto;
            UpdatePhoto = updatePhoto;
            CategoryPhoto = categoryPhoto;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }

        public List<Monument> Monuments { get; set; } = new List<Monument>();
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
