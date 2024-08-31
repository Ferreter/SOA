
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VillaMon_API.Models.Dto;
using VillaMon_API.Tests.Controllers;
using Xunit;

namespace VillaMon_API.Tests
{
    public class TestBookingAPIControllerTests
    {
        private readonly TestBookingAPIController _controller;

        public TestBookingAPIControllerTests()
        {
            // Initialize the test controller
            _controller = new TestBookingAPIController();
        }
        [Fact]
        public void GetAllVillas_ShouldReturnAllVillas()
        {
            // Act
            var result = _controller.GetAllVillas();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result); // Access the Result property
            var villas = Assert.IsType<List<VillaDTO>>(okResult.Value);
            Assert.Equal(3, villas.Count); // Should match the number of villas in LocalStorage
        }



        [Fact]
        public void GetAllBookings_ShouldReturnAllBookings()
        {
            // Act
            var result = _controller.GetAllBookings();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result); // Access the Result property
            var bookings = Assert.IsType<List<BookingDTO>>(okResult.Value);
            Assert.Equal(2, bookings.Count); // Should match the number of bookings in LocalStorage
        }
        [Fact]
        public void GetBookingById_ExistingId_ShouldReturnCorrectBooking()
        {
            // Act
            var result = _controller.GetBookingById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var booking = Assert.IsType<BookingDTO>(okResult.Value);
            Assert.Equal(1, booking.BookingId);
        }

        [Fact]
        public void GetBookingById_NonExistingId_ShouldReturnNotFound()
        {
            // Act
            var result = _controller.GetBookingById(99); // Assuming 99 is a non-existing ID

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void GetBookingById_InvalidId_ShouldReturnNotFound()
        {
            // Act
            var result = _controller.GetBookingById(-1); // Negative ID for invalid test

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public void AddBooking_ValidBooking_ShouldReturnCreatedAtAction()
        {
            // Arrange
            var newBooking = new BookingDTO
            {
                VillaId = 1,
                CheckInDate = System.DateTime.Now.AddDays(1),
                CheckOutDate = System.DateTime.Now.AddDays(3),
                GuestCount = 2
            };

            // Act
            var result = _controller.AddBooking(newBooking);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var booking = Assert.IsType<BookingDTO>(createdAtActionResult.Value);
            Assert.Equal(newBooking.VillaId, booking.VillaId);
        }

        [Fact]
        public void UpdateBooking_ExistingId_ShouldReturnNoContent()
        {
            // Arrange
            var updatedBooking = new BookingDTO
            {
                VillaId = 2,
                CheckInDate = System.DateTime.Now.AddDays(5),
                CheckOutDate = System.DateTime.Now.AddDays(8),
                GuestCount = 3
            };

            // Act
            var result = _controller.UpdateBooking(1, updatedBooking);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void UpdateBooking_NonExistingId_ShouldReturnNotFound()
        {
            // Arrange
            var updatedBooking = new BookingDTO
            {
                VillaId = 2,
                CheckInDate = System.DateTime.Now.AddDays(5),
                CheckOutDate = System.DateTime.Now.AddDays(8),
                GuestCount = 3
            };

            // Act
            var result = _controller.UpdateBooking(99, updatedBooking); // Assuming 99 is a non-existing ID

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void DeleteBooking_ExistingId_ShouldReturnNoContent()
        {
            // Act
            var result = _controller.DeleteBooking(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void DeleteBooking_NonExistingId_ShouldReturnNotFound()
        {
            // Act
            var result = _controller.DeleteBooking(99); // Assuming 99 is a non-existing ID

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
