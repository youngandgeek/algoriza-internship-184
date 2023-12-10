using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer
{

    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        /**public async Task<bool> RegisterAsync(PatientRegistrationDTO registrationDTO)
        {
            // Validate registrationDTO and create a new user
            var user = new ApplicationUser
        {
            UserName = registrationDTO.Email,
            Email = registrationDTO.Email,
            // Other properties...
        };

        var result = await _userManager.CreateAsync(user, registrationDTO.Password);

            if (result.Succeeded)
            {
                // Registration successful
                // You may also want to perform additional tasks, such as sending a confirmation email
                return true;
            }
            else
            {
                // Registration failed
                // Handle errors in result.Errors
                return false;
            }
        }

        public async Task<bool> LoginAsync(string email, string password)
{
    // Find user by email
    var user = await _userManager.FindByEmailAsync(email);

    if (user != null)
    {
        // Validate password
        var result = await _userManager.CheckPasswordAsync(user, password);

        if (result)
        {
            // Login successful
            return true;
        }
    }

    // Login failed
    return false;
}
        **/

        public async Task<List<Doctor>> SearchDoctorsAsync(string search, int page, int pageSize)
        {
            // Call the repository method to search for doctors
            var doctors = await _patientRepository.GetAllDoctorsAsync(search, page, pageSize);

            // You can perform additional logic or mapping here if needed

            return doctors;
        }

        public bool BookAppointment(int patientId, int timeId, string discountCodeCoupon)
        {
            // Implement booking appointment logic, including validation and saving to the repository
            throw new System.NotImplementedException();
        }

        public async Task<List<Appointment>> GetPatientBookingsAsync(int patientId)
        {
            return await _patientRepository.GetPatientBookingsAsync(patientId);
        }

        public async Task<bool> CancelBookingAsync(int bookingId)
        {
            return await _patientRepository.CancelBookingAsync(bookingId);
        }

        Task<bool> IPatientService.BookAppointment(int patientId, int timeId, string discountCodeCoupon)
        {
            throw new NotImplementedException();
        }
    }

}