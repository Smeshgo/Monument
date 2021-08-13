using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Photo
    {
        public Photo()
        {
        }
        [Key]
        public Guid IdPhoto { get; set; }
        public string Name { get; set; }
        public string PathFull { get; set; }
        public string PathMini { get; set; }
        public string Uuid { get; set; }
        public DateTime? CreatePhoto { get; set; }
        public DateTime? UpdatePhoto { get; set; }
        public Guid IdCategoryPhoto { get; set; }

        public CategoryPhoto CategoryPhoto { get; set; }
        public List<Monument> Monuments { get; set; } = new List<Monument>();
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
