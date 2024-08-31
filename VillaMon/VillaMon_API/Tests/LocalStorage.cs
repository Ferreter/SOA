
using System;
using System.Collections.Generic;
using VillaMon_API.Models.Dto;

namespace VillaMon_API.Data
{
    public class LocalStorage
    {
        // Simulating local storage for Villas
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO 
            { 
                Id = 1, 
                Name = "Villa 1", 
                Details = "A beautiful beachfront villa", 
                Rate = 350.50, 
                Sqft = 2000, 
                Occupancy = 4, 
                ImageUrl = "https://example.com/villa1.jpg"
            },
            new VillaDTO 
            { 
                Id = 2, 
                Name = "Villa 2", 
                Details = "A luxurious mountain villa", 
                Rate = 500.75, 
                Sqft = 3000, 
                Occupancy = 6, 
                ImageUrl = "https://example.com/villa2.jpg"
            },
            new VillaDTO 
            { 
                Id = 3, 
                Name = "Villa 3", 
                Details = "A cozy countryside villa", 
                Rate = 250.00, 
                Sqft = 1800, 
                Occupancy = 3, 
                ImageUrl = "https://example.com/villa3.jpg"
            }
        };

        // Simulating local storage for Bookings
        public static List<BookingDTO> bookingList = new List<BookingDTO>
        {
            new BookingDTO 
            { 
                BookingId = 1, 
                VillaId = 1, 
                CheckInDate = DateTime.Now.AddDays(-10), 
                CheckOutDate = DateTime.Now.AddDays(-5), 
                GuestCount = 2
            },
            new BookingDTO 
            { 
                BookingId = 2, 
                VillaId = 2, 
                CheckInDate = DateTime.Now.AddDays(-20), 
                CheckOutDate = DateTime.Now.AddDays(-15), 
                GuestCount = 4
            }
        };
    }
}
