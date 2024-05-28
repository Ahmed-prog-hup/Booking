using Booking.Models;

namespace Booking.Repositories
{
    public interface IBookingRepository
    {
        // Adding Reserve
        Task<booking> AddBookingAsync(booking booking);
        // Get All Reservations
        Task<IEnumerable<booking>> GetBookingsAsync();
        // Get Reserve By Id
        Task<booking> GetBookingByIdAsync(int id);
    }
}
