using System;

#nullable disable

namespace MonumentMlyn.BLL.DTO
{
    public class MaterialDto
    {
        public MaterialDto()
        {

        }

        public MaterialDto(Guid idMaterial, string name, decimal height, decimal length, string color,
            decimal width, decimal price, decimal number, string status, DateTime? createMaterial, 
            DateTime? updateMaterial, Guid idAppointment, Guid idCategoryMaterial, AppointmentDto appointment , CategoryMaterialDto categoryMaterial)
        {
            this.IdMaterial = idMaterial;
            this.Name = name;
            this.Height = height;
            this.Length = length;
            this.Color = color;
            this.Width = width;
            this.Price = price;
            this.Number = number;
            this.Status = status;
            this.CreateMaterial = createMaterial;
            this.UpdateMaterial = updateMaterial;
            this.IdAppointment = idAppointment;
            this.IdCategoryMaterial = idCategoryMaterial;
            this.Appointment = appointment;
            this.CategoryMaterial = categoryMaterial;
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
        public DateTime? CreateMaterial { get; set; }
        public DateTime? UpdateMaterial { get; set; }
        public Guid IdAppointment { get; set; }
        public Guid IdCategoryMaterial { get; set; }
        public AppointmentDto Appointment { get; set; }
        public CategoryMaterialDto CategoryMaterial { get; set; }
    }
}
