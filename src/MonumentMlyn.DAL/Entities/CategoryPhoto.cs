using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class CategoryPhoto
    {
        public CategoryPhoto()
        {
            Photos = new HashSet<Photo>();
        }
        [Key]
        public Guid IdCategoryPhoto { get; set; }
        public string Name { get; set; }
        public DateTime? CreatePhotoPhoto { get; set; }
        public DateTime? UpdateCategoryPhoto { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
