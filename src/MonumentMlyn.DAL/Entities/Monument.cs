using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Monument
    {
        public Monument()
        {

        }
        [Key]
        public Guid IdMonument { get; set; }
        public decimal Prise { get; set; }
        public Guid IdPhoto { get; set; }
        public Guid Id_customer { get; set; }

        public Photo Photo { get; set; }
        public List<Material> Materials { get; set; } = new List<Material>();
        public List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
