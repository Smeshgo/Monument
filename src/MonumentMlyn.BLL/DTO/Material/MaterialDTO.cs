using MonumentMlyn.DAL.Enum;
using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class MaterialDto
    {
        public MaterialDto()
        {

        }

        public MaterialDto(Guid idMaterial, string name, decimal height, decimal length, string color, decimal width, decimal price, decimal number, string status, Appointment appointment, CategoryMaterial category, DateTime? createMaterial, DateTime? updateMaterial)
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
            Appointment = appointment.ToString();
            Category = category.ToString();
            CreateMaterial = createMaterial;
            UpdateMaterial = updateMaterial;
        }


        public Guid IdMaterial { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public string Color { get; set; }
        public decimal Width { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public string Status { get; set; }

        public string Appointment { get; set; }
        public string Category { get; set; }
        public DateTime? CreateMaterial { get; set; }
        public DateTime? UpdateMaterial { get; set; }
    }
}
