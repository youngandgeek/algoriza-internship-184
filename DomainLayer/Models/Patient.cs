using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using DomainLayer.Enums;

    namespace DomainLayer.Models

{
    public class Patient
    {
      
            public int Id { get; set; }
            public byte[] Image { get; set; } // byte array for storing images
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public Gender Gender { get; set; }
            public DateTime DateOfBirth { get; set; }

            // Navigation property for booked appointments
         public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        }
    }

