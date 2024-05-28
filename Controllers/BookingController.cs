using Booking.Models;
using Booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class BookingsController : ControllerBase
        {
            private readonly BookingService _bookingService;

            public BookingsController(BookingService bookingService)
            {
                _bookingService = bookingService;
            }

            [HttpPost]
            public async Task<IActionResult> CreateBooking([FromBody] booking booking)
            {
                var result = await _bookingService.CreateBookingAsync(booking);
                return Ok(result);
            }

            [HttpGet]
            public async Task<IEnumerable<booking>> GetBookings()
            {
                return await _bookingService.GetBookingsAsync();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetBookingById(int id)
            {
                var booking = await _bookingService.GetBookingByIdAsync(id);
                if (booking == null)
                {
                    return NotFound();
                }
                return Ok(booking);
            }
        }
}
