
using DomainLayer.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models

{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Day { get; set; }
        public int TimeId { get; set; }
        public string DiscountCodeCoupon { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // Specify the column type here
        public decimal FinalPrice { get; set; }
        public AppointmentStatus Status { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
      public TimeSlot TimeSlot { get; set; }
    }
}