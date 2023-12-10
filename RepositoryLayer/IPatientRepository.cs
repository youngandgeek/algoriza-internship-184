using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IPatientRepository
    {
        Task<List<Doctor>> GetAllDoctorsAsync();
        Task<List<Appointment>> GetPatientBookingsAsync(int patientId);
        Task<bool> CancelBookingAsync(int bookingId);
    }
}
