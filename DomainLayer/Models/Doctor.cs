using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }
        [Column(TypeName = "decimal(18, 2)")] // Specify the column type here
        public decimal Price { get; set; }
        public Gender Gender { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
