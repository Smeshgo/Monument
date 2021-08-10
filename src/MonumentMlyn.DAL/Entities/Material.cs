using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Material
    {
        public Material()
        {
            MaterialMonuments = new HashSet<MaterialMonument>();
        }
        [Key]
        public Guid IdMaterial { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public string Color { get; set; }
        public decimal Width { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public string Status { get; set; }
        public DateTime? CreateMaterial { get; set; }
        public DateTime? UpdateUser { get; set; }
        public Guid IdAppointment { get; set; }
        public Guid IdCategoryMaterial { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual CategoryMaterial IdCategoryMaterialNavigation { get; set; }
        public virtual ICollection<MaterialMonument> MaterialMonuments { get; set; }
    }
}
