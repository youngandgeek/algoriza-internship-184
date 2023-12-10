using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public string Time { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
