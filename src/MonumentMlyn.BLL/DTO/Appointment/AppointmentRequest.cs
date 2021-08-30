using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.BLL.DTO.Appointment
{
    public class AppointmentRequest
    {
        public AppointmentRequest()
        {
            
        }

        public AppointmentRequest(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        
    }
}
