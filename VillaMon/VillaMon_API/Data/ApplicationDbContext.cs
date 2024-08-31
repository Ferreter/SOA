using Microsoft.EntityFrameworkCore;
using VillaMon_API.Models;

namespace VillaMon_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<Booking> Bookings { get; set; }  // Add this line to include the Bookings table



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Extended Villa seeding data
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "A luxurious villa with royal amenities, including a private pool, garden, and a spacious living area.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 6,
                    Rate = 350,
                    Sqft = 850,
                    Amenity = "Private Pool, Garden, Spa, Gym",
                    CreatedDate = DateTime.Now,
                    Location = "Downtown City Center",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "An exclusive villa near the beach, featuring an infinity pool and breathtaking sea views.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Occupancy = 4,
                    Rate = 450,
                    Sqft = 700,
                    Amenity = "Infinity Pool, Ocean View, BBQ Area",
                    CreatedDate = DateTime.Now,
                    Location = "Seaside",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "A stunning villa with a private pool, state-of-the-art kitchen, and a rooftop terrace.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                    Occupancy = 5,
                    Rate = 500,
                    Sqft = 950,
                    Amenity = "Private Pool, Rooftop Terrace, Modern Kitchen",
                    CreatedDate = DateTime.Now,
                    Location = "Hilltop",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "An exquisite villa with crystal-clear views of the mountains, perfect for those seeking tranquility.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                    Occupancy = 8,
                    Rate = 600,
                    Sqft = 1200,
                    Amenity = "Mountain View, Fireplace, Wine Cellar",
                    CreatedDate = DateTime.Now,
                    Location = "Mountain View",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "A villa with a grand pool and a large courtyard, ideal for large families or groups.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                    Occupancy = 10,
                    Rate = 700,
                    Sqft = 1500,
                    Amenity = "Grand Pool, Large Courtyard, Outdoor Kitchen",
                    CreatedDate = DateTime.Now,
                    Location = "Countryside",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 6,
                    Name = "Eco Villa",
                    Details = "A sustainable villa with solar panels and a rainwater harvesting system.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa6.jpg",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 600,
                    Amenity = "Solar Panels, Rainwater Harvesting, Eco-friendly Appliances",
                    CreatedDate = DateTime.Now,
                    Location = "Forest Edge",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 7,
                    Name = "Beachfront Villa",
                    Details = "A beachfront villa with direct access to the sandy shores.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa7.jpg",
                    Occupancy = 6,
                    Rate = 800,
                    Sqft = 900,
                    Amenity = "Beach Access, Sun Deck, Sea Kayak",
                    CreatedDate = DateTime.Now,
                    Location = "Beachfront",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 8,
                    Name = "Modern Loft Villa",
                    Details = "A stylish loft with modern decor and high ceilings.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa8.jpg",
                    Occupancy = 3,
                    Rate = 400,
                    Sqft = 500,
                    Amenity = "Modern Decor, High Ceilings, Open Floor Plan",
                    CreatedDate = DateTime.Now,
                    Location = "Urban Area",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 9,
                    Name = "Treehouse Villa",
                    Details = "An adventurous villa built atop a tall tree with stunning views.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa9.jpg",
                    Occupancy = 2,
                    Rate = 550,
                    Sqft = 300,
                    Amenity = "Treehouse, Rope Bridge, Nature Walks",
                    CreatedDate = DateTime.Now,
                    Location = "Forest Canopy",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 10,
                    Name = "Cave Villa",
                    Details = "A unique villa built into the rock formations of a cave.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa10.jpg",
                    Occupancy = 4,
                    Rate = 600,
                    Sqft = 750,
                    Amenity = "Cave Rooms, Natural Pools, Unique Experience",
                    CreatedDate = DateTime.Now,
                    Location = "Mountain Cave",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 11,
                    Name = "Skyline Penthouse Villa",
                    Details = "A luxurious penthouse with panoramic city views.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa11.jpg",
                    Occupancy = 4,
                    Rate = 1000,
                    Sqft = 1400,
                    Amenity = "Panoramic Views, Rooftop Pool, Private Elevator",
                    CreatedDate = DateTime.Now,
                    Location = "City Center",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 12,
                    Name = "Mountain Chalet Villa",
                    Details = "A cozy chalet with fireplaces and hot tubs.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa12.jpg",
                    Occupancy = 6,
                    Rate = 750,
                    Sqft = 1100,
                    Amenity = "Fireplaces, Hot Tubs, Mountain View",
                    CreatedDate = DateTime.Now,
                    Location = "Mountain Peak",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 13,
                    Name = "Water Villa",
                    Details = "A villa built on stilts over water, offering tranquility and ocean views.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa13.jpg",
                    Occupancy = 5,
                    Rate = 900,
                    Sqft = 850,
                    Amenity = "Ocean Views, Water Deck, Swimming Access",
                    CreatedDate = DateTime.Now,
                    Location = "Overwater",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 14,
                    Name = "Desert Retreat Villa",
                    Details = "A secluded villa in the desert with unique architecture.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa14.jpg",
                    Occupancy = 2,
                    Rate = 500,
                    Sqft = 650,
                    Amenity = "Desert Views, Private Patios, Stargazing Deck",
                    CreatedDate = DateTime.Now,
                    Location = "Desert",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 15,
                    Name = "Forest Cabin Villa",
                    Details = "A quaint cabin in the forest for a nature getaway.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa15.jpg",
                    Occupancy = 3,
                    Rate = 350,
                    Sqft = 400,
                    Amenity = "Wood Stove, Nature Trails, Wildlife Viewing",
                    CreatedDate = DateTime.Now,
                    Location = "Forest",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 16,
                    Name = "Cliffside Villa",
                    Details = "A villa perched on the edge of a cliff with breathtaking ocean views.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa16.jpg",
                    Occupancy = 4,
                    Rate = 1100,
                    Sqft = 900,
                    Amenity = "Ocean Views, Infinity Pool, Outdoor Fireplace",
                    CreatedDate = DateTime.Now,
                    Location = "Cliffside",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 17,
                    Name = "Island Villa",
                    Details = "A private villa located on its own island, providing total seclusion.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa17.jpg",
                    Occupancy = 8,
                    Rate = 1500,
                    Sqft = 2000,
                    Amenity = "Private Island, Beach Access, Helicopter Pad",
                    CreatedDate = DateTime.Now,
                    Location = "Private Island",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 18,
                    Name = "Countryside Cottage Villa",
                    Details = "A charming cottage with a beautiful garden in the countryside.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa18.jpg",
                    Occupancy = 5,
                    Rate = 300,
                    Sqft = 600,
                    Amenity = "Garden, Farmhouse Kitchen, Fireplace",
                    CreatedDate = DateTime.Now,
                    Location = "Countryside",
                    IsAvailable = true
                },
                new Villa
                {
                    Id = 19,
                    Name = "Riverfront Villa",
                    Details = "A serene villa by the river, perfect for fishing and relaxation.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa19.jpg",
                    Occupancy = 3,
                    Rate = 400,
                    Sqft = 550,
                    Amenity = "Fishing Dock, Hammock, Canoe",
                    CreatedDate = DateTime.Now,
                    Location = "Riverfront",
                    IsAvailable = false
                },
                new Villa
                {
                    Id = 20,
                    Name = "Jungle Safari Villa",
                    Details = "A safari-style villa in the heart of the jungle, with guided wildlife tours.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa20.jpg",
                    Occupancy = 4,
                    Rate = 700,
                    Sqft = 800,
                    Amenity = "Safari Tours, Campfire Area, Wildlife Viewing",
                    CreatedDate = DateTime.Now,
                    Location = "Jungle",
                    IsAvailable = true
                }
            );

            // Extended Booking seeding data
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, VillaId = 1, CheckInDate = DateTime.Now.AddDays(10), CheckOutDate = DateTime.Now.AddDays(15), GuestCount = 4, GuestName = "John Doe", GuestEmail = "john.doe@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 2, VillaId = 2, CheckInDate = DateTime.Now.AddDays(20), CheckOutDate = DateTime.Now.AddDays(25), GuestCount = 2, GuestName = "Jane Smith", GuestEmail = "jane.smith@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 3, VillaId = 3, CheckInDate = DateTime.Now.AddDays(5), CheckOutDate = DateTime.Now.AddDays(8), GuestCount = 3, GuestName = "Alice Johnson", GuestEmail = "alice.johnson@example.com", PaymentStatus = "Cancelled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 4, VillaId = 4, CheckInDate = DateTime.Now.AddDays(12), CheckOutDate = DateTime.Now.AddDays(17), GuestCount = 6, GuestName = "Michael Brown", GuestEmail = "michael.brown@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 5, VillaId = 5, CheckInDate = DateTime.Now.AddDays(2), CheckOutDate = DateTime.Now.AddDays(6), GuestCount = 8, GuestName = "Emily Davis", GuestEmail = "emily.davis@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 6, VillaId = 6, CheckInDate = DateTime.Now.AddDays(11), CheckOutDate = DateTime.Now.AddDays(16), GuestCount = 2, GuestName = "David Wilson", GuestEmail = "david.wilson@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 7, VillaId = 7, CheckInDate = DateTime.Now.AddDays(1), CheckOutDate = DateTime.Now.AddDays(4), GuestCount = 4, GuestName = "Sarah Miller", GuestEmail = "sarah.miller@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 8, VillaId = 8, CheckInDate = DateTime.Now.AddDays(3), CheckOutDate = DateTime.Now.AddDays(9), GuestCount = 3, GuestName = "Jessica White", GuestEmail = "jessica.white@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 9, VillaId = 9, CheckInDate = DateTime.Now.AddDays(14), CheckOutDate = DateTime.Now.AddDays(18), GuestCount = 2, GuestName = "Steven Harris", GuestEmail = "steven.harris@example.com", PaymentStatus = "Cancelled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 10, VillaId = 10, CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(13), GuestCount = 1, GuestName = "Anna Martin", GuestEmail = "anna.martin@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 11, VillaId = 11, CheckInDate = DateTime.Now.AddDays(22), CheckOutDate = DateTime.Now.AddDays(27), GuestCount = 5, GuestName = "Paul Thompson", GuestEmail = "paul.thompson@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 12, VillaId = 12, CheckInDate = DateTime.Now.AddDays(16), CheckOutDate = DateTime.Now.AddDays(19), GuestCount = 2, GuestName = "Olivia Lewis", GuestEmail = "olivia.lewis@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 13, VillaId = 13, CheckInDate = DateTime.Now.AddDays(8), CheckOutDate = DateTime.Now.AddDays(10), GuestCount = 3, GuestName = "Isabella Clark", GuestEmail = "isabella.clark@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 14, VillaId = 14, CheckInDate = DateTime.Now.AddDays(4), CheckOutDate = DateTime.Now.AddDays(9), GuestCount = 4, GuestName = "Daniel Walker", GuestEmail = "daniel.walker@example.com", PaymentStatus = "Cancelled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 15, VillaId = 15, CheckInDate = DateTime.Now.AddDays(2), CheckOutDate = DateTime.Now.AddDays(5), GuestCount = 6, GuestName = "Ethan Hall", GuestEmail = "ethan.hall@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 16, VillaId = 16, CheckInDate = DateTime.Now.AddDays(10), CheckOutDate = DateTime.Now.AddDays(14), GuestCount = 2, GuestName = "Sophia Allen", GuestEmail = "sophia.allen@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 17, VillaId = 17, CheckInDate = DateTime.Now.AddDays(5), CheckOutDate = DateTime.Now.AddDays(7), GuestCount = 8, GuestName = "Matthew Young", GuestEmail = "matthew.young@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 18, VillaId = 18, CheckInDate = DateTime.Now.AddDays(9), CheckOutDate = DateTime.Now.AddDays(11), GuestCount = 1, GuestName = "Chloe King", GuestEmail = "chloe.king@example.com", PaymentStatus = "Pending", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 19, VillaId = 19, CheckInDate = DateTime.Now.AddDays(6), CheckOutDate = DateTime.Now.AddDays(8), GuestCount = 3, GuestName = "Grace Scott", GuestEmail = "grace.scott@example.com", PaymentStatus = "Cancelled", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Booking { BookingId = 20, VillaId = 20, CheckInDate = DateTime.Now.AddDays(12), CheckOutDate = DateTime.Now.AddDays(15), GuestCount = 5, GuestName = "Benjamin Turner", GuestEmail = "benjamin.turner@example.com", PaymentStatus = "Paid", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }


        // You can add seed data for the Booking entity here if necessary
    }
}

