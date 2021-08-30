using System;

namespace MonumentMlyn.BLL.DTO
{
    public class MaterialRequest
    {
        public MaterialRequest()
        {
            
        }

        public MaterialRequest(string name, decimal height, decimal length, string color, decimal width, decimal price, decimal number, string status, DateTime? createMaterial, DateTime? updateMaterial, Guid idAppointment, Guid idCategoryMaterial)
        {
            Name = name;
            Height = height;
            Length = length;
            Color = color;
            Width = width;
            Price = price;
            Number = number;
            Status = status;
            CreateMaterial = createMaterial;
            UpdateMaterial = updateMaterial;
            IdAppointment = idAppointment;
            IdCategoryMaterial = idCategoryMaterial;
        }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public string Color { get; set; }
        public decimal Width { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public string Status { get; set; }
        public DateTime? CreateMaterial { get; set; }
        public DateTime? UpdateMaterial { get; set; }
        public Guid IdAppointment { get; set; }
        public Guid IdCategoryMaterial { get; set; }
    }
}