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
            Monuments = new HashSet<Monument>();
            PhotoArticles = new HashSet<PhotoArticle>();
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

        public virtual CategoryPhoto IdCategoryPhotoNavigation { get; set; }
        public virtual ICollection<Monument> Monuments { get; set; }
        public virtual ICollection<PhotoArticle> PhotoArticles { get; set; }
    }
}
