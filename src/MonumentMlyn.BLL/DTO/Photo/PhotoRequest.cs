using Microsoft.AspNetCore.Http;
using MonumentMlyn.DAL.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonumentMlyn.BLL.DTO
{
    public class PhotoRequest
    {
        public PhotoRequest()
        {

        }

        public PhotoRequest(string name, IFormFile pathFull, IFormFile pathMini, CategoryPhoto categoryPhoto)
        {
            Name = name;
            PathFull = pathFull;
            PathMini = pathMini;
            CategoryPhoto = categoryPhoto;
        }

       // [Required] 
        public string Name { get; set; }
       // [NotMapped]
        [Required]
        public IFormFile PathFull { get; set; }
       // [NotMapped]
        [Required] 
        public IFormFile PathMini { get; set; }
        public CategoryPhoto CategoryPhoto { get; set; }

    }
}