using DomainLayer.Enums;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class PatientRepository: IPatientRepository
    {
        private readonly DbConClass _dbContext;

        public PatientRepository(DbConClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await _dbContext.Doctors
                .Include(d => d.Appointments)
                    .ThenInclude(a => a.TimeSlot)
                .ToListAsync();
        }

        public async Task<List<Appointment>> GetPatientBookingsAsync(int patientId)
        {
            return await _dbContext.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.TimeSlot)
                .Where(a => a.PatientId == patientId)
                .ToListAsync();
        }

        public async Task<bool> CancelBookingAsync(int bookingId)
        {
            var appointment = await _dbContext.Appointments.FindAsync(bookingId);

            if (appointment == null)
                return false;

            appointment.Status = AppointmentStatus.Canceled;
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
 