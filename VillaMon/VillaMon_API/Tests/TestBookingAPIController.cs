
using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Data;
using VillaMon_API.Models.Dto;
using System.Collections.Generic;
using System.Linq;

namespace VillaMon_API.Tests.Controllers
{
    [ApiController]
    [Route("api/TestBookingAPI")]
    public class TestBookingAPIController : ControllerBase
    {
        private readonly List<VillaDTO> _villas;
        private readonly List<BookingDTO> _bookings;

        public TestBookingAPIController()
        {
            // Use local storage data instead of database context
            _villas = LocalStorage.villaList;
            _bookings = LocalStorage.bookingList;
        }

        // GET: api/TestBookingAPI/Villas
        [HttpGet("Villas")]
        public ActionResult<IEnumerable<VillaDTO>> GetAllVillas()
        {
            return Ok(_villas);
        }

        // GET: api/TestBookingAPI/Bookings
        [HttpGet("Bookings")]
        public ActionResult<IEnumerable<BookingDTO>> GetAllBookings()
        {
            return Ok(_bookings);
        }

        // GET: api/TestBookingAPI/Booking/1
        [HttpGet("Booking/{id}")]
        public ActionResult<BookingDTO> GetBookingById(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }

        // Additional methods can be added here for creating, updating, or deleting bookings
        // that would use the local storage (_bookings and _villas) for testing purposes.
    }
}
