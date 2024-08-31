
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
        // POST: api/TestBookingAPI/AddBooking
        [HttpPost("AddBooking")]
        public ActionResult AddBooking(BookingDTO newBooking)
        {
            if (newBooking == null || newBooking.VillaId <= 0 || newBooking.CheckInDate >= newBooking.CheckOutDate)
            {
                return BadRequest("Invalid booking details.");
            }

            newBooking.BookingId = _bookings.Max(b => b.BookingId) + 1;
            _bookings.Add(newBooking);
            return CreatedAtAction(nameof(GetBookingById), new { id = newBooking.BookingId }, newBooking);
        }

        // PUT: api/TestBookingAPI/UpdateBooking/1
        [HttpPut("UpdateBooking/{id}")]
        public ActionResult UpdateBooking(int id, BookingDTO updatedBooking)
        {
            var existingBooking = _bookings.FirstOrDefault(b => b.BookingId == id);
            if (existingBooking == null)
            {
                return NotFound();
            }

            if (updatedBooking == null || updatedBooking.VillaId <= 0 || updatedBooking.CheckInDate >= updatedBooking.CheckOutDate)
            {
                return BadRequest("Invalid booking details.");
            }

            existingBooking.VillaId = updatedBooking.VillaId;
            existingBooking.CheckInDate = updatedBooking.CheckInDate;
            existingBooking.CheckOutDate = updatedBooking.CheckOutDate;
            existingBooking.GuestCount = updatedBooking.GuestCount;

            return NoContent();
        }

        // DELETE: api/TestBookingAPI/DeleteBooking/1
        [HttpDelete("DeleteBooking/{id}")]
        public ActionResult DeleteBooking(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            _bookings.Remove(booking);
            return NoContent();
        }

    }
}
