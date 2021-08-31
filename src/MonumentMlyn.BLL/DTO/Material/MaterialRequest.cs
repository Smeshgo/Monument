using System;
using MonumentMlyn.DAL.Enum;

namespace MonumentMlyn.BLL.DTO
{
    public class MaterialRequest
    {
        public MaterialRequest()
        {
            
        }

        public MaterialRequest(string name, decimal height, decimal length, string color, decimal width, decimal price, decimal number, string status, Appointment appointment, CategoryMaterial category)
        {
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
        }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public string Color { get; set; }
        public decimal Width { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public string Status { get; set; }
        public Appointment Appointment { get; set; }
        public CategoryMaterial Category { get; set; }

    }
}