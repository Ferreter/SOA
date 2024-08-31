
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
            var okResult = Assert.IsType<OkObjectResult>(result);
            var booking = Assert.IsType<BookingDTO>(okResult.Value);
            Assert.Equal(1, booking.BookingId);
        }

        [Fact]
        public void GetBookingById_NonExistingId_ShouldReturnNotFound()
        {
            // Act
            var result = _controller.GetBookingById(99); // Assuming 99 is a non-existing ID

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void GetBookingById_InvalidId_ShouldReturnNotFound()
        {
            // Act
            var result = _controller.GetBookingById(-1); // Negative ID for invalid test

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
