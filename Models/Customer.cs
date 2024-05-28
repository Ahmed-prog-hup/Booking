using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? NationalId { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public bool HasPreviousBookings { get; set; }
    }
}
