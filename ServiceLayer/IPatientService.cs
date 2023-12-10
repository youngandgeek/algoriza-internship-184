using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DTO;

namespace ServiceLayer
{
    public interface IPatientService
    {
          /** Task<bool> RegisterAsync(PatientRegistrationDTO registrationDTO);
            Task<bool> LoginAsync(string email, string password);
          **/    
            Task<List<Doctor>> SearchDoctorsAsync(string search, int page, int pageSize);
            Task<bool> BookAppointment(int patientId, int timeId, string discountCodeCoupon);
            Task<List<Appointment>> GetPatientBookingsAsync(int patientId);
            Task<bool> CancelBookingAsync(int bookingId);
        
    }
}
