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

        public Monument(Guid monumentId, decimal price, Guid photoId, Guid customerId, Customer customer, Photo? photo)
        {
            MonumentId = monumentId;
            Price = price;
            PhotoId = photoId;
            CustomerId = customerId;
            Customer = customer;
            Photo = photo;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MonumentId { get; set; }
        public decimal Price { get; set; }
        public Guid? PhotoId { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
        public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();

    }
}
