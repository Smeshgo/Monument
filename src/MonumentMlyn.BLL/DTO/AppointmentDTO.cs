using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO
{
    class AppointmentDTO
    {
        public AppointmentDTO()
        {
            MaterialsDtos = new HashSet<MaterialDTO>();
        }

        public Guid IdAppointment { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAppointment { get; set; }
        public DateTime? Update { get; set; }

        public virtual ICollection<MaterialDTO> MaterialsDtos { get; set; }
    }
}
