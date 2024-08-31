using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaMon_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataForBookingAndVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreatedDate", "GuestCount", "GuestEmail", "GuestName", "PaymentStatus", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 10, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 9, 15, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2324), 4, "john.doe@example.com", "John Doe", "Paid", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2325), 1 },
                    { 2, new DateTime(2024, 9, 20, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 9, 25, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2328), 2, "jane.smith@example.com", "Jane Smith", "Pending", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2329), 2 },
                    { 3, new DateTime(2024, 9, 5, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 9, 8, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2333), 3, "alice.johnson@example.com", "Alice Johnson", "Cancelled", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2334), 3 },
                    { 4, new DateTime(2024, 9, 12, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 9, 17, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2337), 6, "michael.brown@example.com", "Michael Brown", "Paid", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2338), 4 },
                    { 5, new DateTime(2024, 9, 2, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 9, 6, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2341), 8, "emily.davis@example.com", "Emily Davis", "Paid", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2342), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Private Pool, Garden, Spa, Gym", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2207), "A luxurious villa with royal amenities, including a private pool, garden, and a spacious living area.", "Downtown City Center", 6, 350.0, 850 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Rate", "Sqft" },
                values: new object[] { "Infinity Pool, Ocean View, BBQ Area", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2247), "An exclusive villa near the beach, featuring an infinity pool and breathtaking sea views.", false, "Seaside", 450.0, 700 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Private Pool, Rooftop Terrace, Modern Kitchen", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2250), "A stunning villa with a private pool, state-of-the-art kitchen, and a rooftop terrace.", "Hilltop", 5, 500.0, 950 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Mountain View, Fireplace, Wine Cellar", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2252), "An exquisite villa with crystal-clear views of the mountains, perfect for those seeking tranquility.", "Mountain View", 8, 600.0, 1200 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Grand Pool, Large Courtyard, Outdoor Kitchen", new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2254), "A villa with a grand pool and a large courtyard, ideal for large families or groups.", false, 10, 700.0, 1500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "", new DateTime(2024, 8, 31, 1, 50, 1, 625, DateTimeKind.Local).AddTicks(707), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "City Center", 4, 200.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Rate", "Sqft" },
                values: new object[] { "", new DateTime(2024, 8, 31, 1, 50, 1, 625, DateTimeKind.Local).AddTicks(745), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", true, "Near the Beach", 300.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "", new DateTime(2024, 8, 31, 1, 50, 1, 625, DateTimeKind.Local).AddTicks(748), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Mountain View", 4, 400.0, 750 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "", new DateTime(2024, 8, 31, 1, 50, 1, 625, DateTimeKind.Local).AddTicks(750), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Suburban Area", 4, 550.0, 900 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "", new DateTime(2024, 8, 31, 1, 50, 1, 625, DateTimeKind.Local).AddTicks(752), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", true, 4, 600.0, 1100 });
        }
    }
}
