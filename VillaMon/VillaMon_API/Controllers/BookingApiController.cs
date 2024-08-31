using Microsoft.AspNetCore.Mvc;
using VillaMon_API.Data;
using VillaMon_API.Models;
using VillaMon_API.Models.Dto;
using System.Collections.Generic;
using System.Linq;

namespace VillaMon_API.Controllers
{
    [ApiController]
    [Route("api/BookingAPI")]
    public class BookingAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public BookingAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/BookingAPI
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<BookingDTO>> GetBookings()
        {
            var bookingList = _db.Bookings.ToList();
            return Ok(bookingList);
        }

        // GET: api/BookingAPI/{id}
        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<BookingDTO> GetBooking(int id)
        {
            var booking = _db.Bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
        // GET: api/BookingAPI/ByVilla/{villaId}
        [HttpGet("ByVilla/{villaId:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<BookingDTO>> GetBookingsByVillaId(int villaId)
        {
            var bookings = _db.Bookings.Where(b => b.VillaId == villaId).ToList();
            if (bookings == null || !bookings.Any())
            {
                return NotFound($"No bookings found for Villa with ID {villaId}");
            }
            return Ok(bookings);
        }


        // POST: api/BookingAPI
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult<BookingDTO> CreateBooking(BookingDTO bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (bookingDto == null)
            {
                return BadRequest("Booking is null");
            }

            Booking booking = new()
            {
                VillaId = bookingDto.VillaId,
                CheckInDate = bookingDto.CheckInDate,
                CheckOutDate = bookingDto.CheckOutDate,
                GuestCount = bookingDto.GuestCount,
                GuestName = bookingDto.GuestName,
                GuestEmail = bookingDto.GuestEmail,
                PaymentStatus = bookingDto.PaymentStatus,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            _db.Bookings.Add(booking);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetBooking), new { id = booking.BookingId }, booking);
        }

        // PUT: api/BookingAPI/{id}
        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<BookingDTO> UpdateBooking(int id, BookingDTO bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingBooking = _db.Bookings.FirstOrDefault(b => b.BookingId == id);
            if (existingBooking == null)
            {
                return NotFound();
            }

            existingBooking.CheckInDate = bookingDto.CheckInDate;
            existingBooking.CheckOutDate = bookingDto.CheckOutDate;
            existingBooking.GuestCount = bookingDto.GuestCount;
            existingBooking.GuestName = bookingDto.GuestName;
            existingBooking.GuestEmail = bookingDto.GuestEmail;
            existingBooking.PaymentStatus = bookingDto.PaymentStatus;
            existingBooking.UpdatedDate = DateTime.Now;

            _db.Bookings.Update(existingBooking);
            _db.SaveChanges();

            return Ok(existingBooking);
        }

        // DELETE: api/BookingAPI/{id}
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public ActionResult DeleteBooking(int id)
        {
            var booking = _db.Bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            _db.Bookings.Remove(booking);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
