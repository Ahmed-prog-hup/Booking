using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class booking
    {
        [Key]
        public int Id { get; set; }
        public Customer? Customer { get; set; }
        public string? HotelBranch { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public List<Room>? Rooms { get; set; }
        public double TotalCost { get; set; }
    }
}
