using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Material
    {
        public Material()
        {
        }

        public Material(Guid idMaterial, string name, decimal height, decimal length, string color, decimal width, decimal price, decimal number, string status, DateTime? createMaterial, DateTime? updateUser, Guid idAppointment, Guid idCategoryMaterial, Appointment appointment, CategoryMaterial categoryMaterial)
        {
            IdMaterial = idMaterial;
            Name = name;
            Height = height;
            Length = length;
            Color = color;
            Width = width;
            Price = price;
            Number = number;
            Status = status;
            CreateMaterial = createMaterial;
            UpdateUser = updateUser;
            IdAppointment = idAppointment;
            IdCategoryMaterial = idCategoryMaterial;
            Appointment = appointment;
            CategoryMaterial = categoryMaterial;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

      //  public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public Appointment Appointment { get; set; }
        public CategoryMaterial CategoryMaterial { get; set; }
        
        public List<Monument> Monuments { get; set; } = new List<Monument>();
    }
}
