using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MonumentMlyn.DAL.Enum;

#nullable disable

namespace MonumentMlyn.DAL.Entities
{
    public partial class Material
    {
        public Material()
        {
        }

        public Material(Guid idMaterial, string name, decimal height, decimal length, Color color, decimal width, decimal price, decimal number, StatusMaterial status, Appointment appointment, CategoryMaterial category, DateTime? createMaterial, DateTime? updateMaterial)
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
            Appointment = appointment;
            Category = category;
            CreateMaterial = createMaterial;
            UpdateMaterial = updateMaterial;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdMaterial { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public Color Color { get; set; }
        public decimal Width { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public StatusMaterial Status { get; set; }
        public Appointment Appointment { get; set; }
        public CategoryMaterial Category { get; set; }
        public DateTime? CreateMaterial { get; set; }
        public DateTime? UpdateMaterial { get; set; }

        public List<Monument> Monuments { get; set; } = new List<Monument>();
    }
}
