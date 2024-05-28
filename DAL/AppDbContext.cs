using Booking.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
