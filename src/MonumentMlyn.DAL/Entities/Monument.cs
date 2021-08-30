using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Monument
    {
        public Monument()
        {

        }

        public Monument(Guid idMonument, decimal price, Guid idPhoto, Guid idCustomer, Photo photo)
        {
            IdMonument = idMonument;
            Price = price;
            IdPhoto = idPhoto;
            Id_customer = idCustomer;
            Photo = photo;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdMonument { get; set; }
        public decimal Price { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid Id_customer { get; set; }

        public Photo Photo { get; set; }
        public List<Material> Materials { get; set; } = new List<Material>();
        public List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
