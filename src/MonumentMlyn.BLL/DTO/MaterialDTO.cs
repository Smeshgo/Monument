using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class MaterialDTO
    {
        public MaterialDTO()
        {
            MaterialMonuments = new HashSet<MaterialMonumentDTO>();
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
        public DateTime? UpdateUser { get; set; }
        public Guid IdAppointment { get; set; }
        public Guid IdCategoryMaterial { get; set; }

        public virtual AppointmentDTO IdAppointmentNavigation { get; set; }
        public virtual CategoryMaterialDTO IdCategoryMaterialNavigation { get; set; }
        public virtual ICollection<MaterialMonumentDTO> MaterialMonuments { get; set; }
    }
}
