using Booking.Models;
using Booking.Repositories;

namespace Booking.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<booking> CreateBookingAsync(booking booking)
        {
            if (booking.Customer.HasPreviousBookings)
            {
                booking.TotalCost *= 0.95; // Apply 5% discount
            }

            return await _bookingRepository.AddBookingAsync(booking);
        }

        public async Task<IEnumerable<booking>> GetBookingsAsync()
        {
            return await _bookingRepository.GetBookingsAsync();
        }

        public async Task<booking> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }
    }
}
