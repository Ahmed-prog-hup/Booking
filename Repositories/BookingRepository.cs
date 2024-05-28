using Booking.DAL;
using Booking.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        public BookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<booking> AddBookingAsync(booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<IEnumerable<booking>> GetBookingsAsync()
        {
            return await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Rooms)
                .ToListAsync();
        }

        public async Task<booking> GetBookingByIdAsync(int id)
        {
            return await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Rooms)
                .FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
