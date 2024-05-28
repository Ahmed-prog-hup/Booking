using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Type { get; set; }
        public int NumOf_Adults { get; set; }
        public int NumOf_Children { get; set; }
    }
}
