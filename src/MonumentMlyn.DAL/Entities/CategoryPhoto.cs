using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class CategoryPhoto
    {
        public CategoryPhoto()
        {

        }

        public CategoryPhoto(Guid idCategoryPhoto, string name, DateTime? createPhotoPhoto, DateTime? updateCategoryPhoto)
        {
            IdCategoryPhoto = idCategoryPhoto;
            Name = name;
            CreatePhotoPhoto = createPhotoPhoto;
            UpdateCategoryPhoto = updateCategoryPhoto;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCategoryPhoto { get; set; }
        public string Name { get; set; }
        public DateTime? CreatePhotoPhoto { get; set; }
        public DateTime? UpdateCategoryPhoto { get; set; }

    }
}
