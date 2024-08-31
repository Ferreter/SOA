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

            // Improved Villa seeding data
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
                });

            // Improved Booking seeding data
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingId = 1,
                    VillaId = 1, // Relates to "Royal Villa"
                    CheckInDate = DateTime.Now.AddDays(10),
                    CheckOutDate = DateTime.Now.AddDays(15),
                    GuestCount = 4,
                    GuestName = "John Doe",
                    GuestEmail = "john.doe@example.com",
                    PaymentStatus = "Paid",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Booking
                {
                    BookingId = 2,
                    VillaId = 2, // Relates to "Premium Pool Villa"
                    CheckInDate = DateTime.Now.AddDays(20),
                    CheckOutDate = DateTime.Now.AddDays(25),
                    GuestCount = 2,
                    GuestName = "Jane Smith",
                    GuestEmail = "jane.smith@example.com",
                    PaymentStatus = "Pending",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Booking
                {
                    BookingId = 3,
                    VillaId = 3, // Relates to "Luxury Pool Villa"
                    CheckInDate = DateTime.Now.AddDays(5),
                    CheckOutDate = DateTime.Now.AddDays(8),
                    GuestCount = 3,
                    GuestName = "Alice Johnson",
                    GuestEmail = "alice.johnson@example.com",
                    PaymentStatus = "Cancelled",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Booking
                {
                    BookingId = 4,
                    VillaId = 4, // Relates to "Diamond Villa"
                    CheckInDate = DateTime.Now.AddDays(12),
                    CheckOutDate = DateTime.Now.AddDays(17),
                    GuestCount = 6,
                    GuestName = "Michael Brown",
                    GuestEmail = "michael.brown@example.com",
                    PaymentStatus = "Paid",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Booking
                {
                    BookingId = 5,
                    VillaId = 5, // Relates to "Diamond Pool Villa"
                    CheckInDate = DateTime.Now.AddDays(2),
                    CheckOutDate = DateTime.Now.AddDays(6),
                    GuestCount = 8,
                    GuestName = "Emily Davis",
                    GuestEmail = "emily.davis@example.com",
                    PaymentStatus = "Paid",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                });
        }

        // You can add seed data for the Booking entity here if necessary
    }
    }

