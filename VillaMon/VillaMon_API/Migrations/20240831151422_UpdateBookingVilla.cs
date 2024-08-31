using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaMon_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookingVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 9, 15, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5247), new DateTime(2024, 9, 25, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 9, 8, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 9, 17, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5261), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 9, 6, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5265), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5267), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreatedDate", "GuestCount", "GuestEmail", "GuestName", "PaymentStatus", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 9, 11, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 9, 16, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5272), 2, "david.wilson@example.com", "David Wilson", "Pending", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5273), 6 },
                    { 7, new DateTime(2024, 9, 1, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 9, 4, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5278), 4, "sarah.miller@example.com", "Sarah Miller", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5279), 7 },
                    { 8, new DateTime(2024, 9, 3, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 9, 9, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5283), 3, "jessica.white@example.com", "Jessica White", "Pending", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5284), 8 },
                    { 9, new DateTime(2024, 9, 14, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 9, 18, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5288), 2, "steven.harris@example.com", "Steven Harris", "Cancelled", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5289), 9 },
                    { 10, new DateTime(2024, 9, 7, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 9, 13, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5293), 1, "anna.martin@example.com", "Anna Martin", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5294), 10 },
                    { 11, new DateTime(2024, 9, 22, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 9, 27, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5297), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5299), 5, "paul.thompson@example.com", "Paul Thompson", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5300), 11 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Rate", "Sqft" },
                values: new object[] { "Solar Panels, Rainwater Harvesting, Eco-friendly Appliances", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5073), "A sustainable villa with solar panels and a rainwater harvesting system.", "Forest Edge", "Eco Villa", 300.0, 600 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Rate" },
                values: new object[] { "Beach Access, Sun Deck, Sea Kayak", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5075), "A beachfront villa with direct access to the sandy shores.", "Beachfront", "Beachfront Villa", 800.0 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Modern Decor, High Ceilings, Open Floor Plan", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5077), "A stylish loft with modern decor and high ceilings.", "Urban Area", "Modern Loft Villa", 3, 400.0, 500 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Treehouse, Rope Bridge, Nature Walks", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5080), "An adventurous villa built atop a tall tree with stunning views.", "Forest Canopy", "Treehouse Villa", 2, 550.0, 300 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Cave Rooms, Natural Pools, Unique Experience", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5082), "A unique villa built into the rock formations of a cave.", false, "Mountain Cave", "Cave Villa", 4, 600.0, 750 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Name", "Rate", "Sqft" },
                values: new object[] { "Panoramic Views, Rooftop Pool, Private Elevator", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5085), "A luxurious penthouse with panoramic city views.", true, "City Center", "Skyline Penthouse Villa", 1000.0, 1400 });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "IsAvailable", "Location", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 12, "Fireplaces, Hot Tubs, Mountain View", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5088), "A cozy chalet with fireplaces and hot tubs.", "https://dotnetmastery.com/bluevillaimages/villa12.jpg", false, "Mountain Peak", "Mountain Chalet Villa", 6, 750.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Ocean Views, Water Deck, Swimming Access", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5091), "A villa built on stilts over water, offering tranquility and ocean views.", "https://dotnetmastery.com/bluevillaimages/villa13.jpg", true, "Overwater", "Water Villa", 5, 900.0, 850, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Desert Views, Private Patios, Stargazing Deck", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5093), "A secluded villa in the desert with unique architecture.", "https://dotnetmastery.com/bluevillaimages/villa14.jpg", false, "Desert", "Desert Retreat Villa", 2, 500.0, 650, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Wood Stove, Nature Trails, Wildlife Viewing", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5095), "A quaint cabin in the forest for a nature getaway.", "https://dotnetmastery.com/bluevillaimages/villa15.jpg", true, "Forest", "Forest Cabin Villa", 3, 350.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Ocean Views, Infinity Pool, Outdoor Fireplace", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5098), "A villa perched on the edge of a cliff with breathtaking ocean views.", "https://dotnetmastery.com/bluevillaimages/villa16.jpg", true, "Cliffside", "Cliffside Villa", 4, 1100.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Private Island, Beach Access, Helicopter Pad", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5100), "A private villa located on its own island, providing total seclusion.", "https://dotnetmastery.com/bluevillaimages/villa17.jpg", false, "Private Island", "Island Villa", 8, 1500.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Garden, Farmhouse Kitchen, Fireplace", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5102), "A charming cottage with a beautiful garden in the countryside.", "https://dotnetmastery.com/bluevillaimages/villa18.jpg", true, "Countryside", "Countryside Cottage Villa", 5, 300.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Fishing Dock, Hammock, Canoe", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5104), "A serene villa by the river, perfect for fishing and relaxation.", "https://dotnetmastery.com/bluevillaimages/villa19.jpg", false, "Riverfront", "Riverfront Villa", 3, 400.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Safari Tours, Campfire Area, Wildlife Viewing", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5107), "A safari-style villa in the heart of the jungle, with guided wildlife tours.", "https://dotnetmastery.com/bluevillaimages/villa20.jpg", true, "Jungle", "Jungle Safari Villa", 4, 700.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CreatedDate", "GuestCount", "GuestEmail", "GuestName", "PaymentStatus", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 12, new DateTime(2024, 9, 16, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 9, 19, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5304), 2, "olivia.lewis@example.com", "Olivia Lewis", "Pending", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5305), 12 },
                    { 13, new DateTime(2024, 9, 8, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5307), new DateTime(2024, 9, 10, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5309), 3, "isabella.clark@example.com", "Isabella Clark", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5310), 13 },
                    { 14, new DateTime(2024, 9, 4, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 9, 9, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5314), 4, "daniel.walker@example.com", "Daniel Walker", "Cancelled", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5315), 14 },
                    { 15, new DateTime(2024, 9, 2, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 9, 5, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5320), 6, "ethan.hall@example.com", "Ethan Hall", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5321), 15 },
                    { 16, new DateTime(2024, 9, 10, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 9, 14, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5323), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5325), 2, "sophia.allen@example.com", "Sophia Allen", "Pending", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5326), 16 },
                    { 17, new DateTime(2024, 9, 5, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 9, 7, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5329), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5330), 8, "matthew.young@example.com", "Matthew Young", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5331), 17 },
                    { 18, new DateTime(2024, 9, 9, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 9, 11, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5334), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5335), 1, "chloe.king@example.com", "Chloe King", "Pending", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5336), 18 },
                    { 19, new DateTime(2024, 9, 6, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 9, 8, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5339), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5341), 3, "grace.scott@example.com", "Grace Scott", "Cancelled", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5342), 19 },
                    { 20, new DateTime(2024, 9, 12, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5343), new DateTime(2024, 9, 15, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5346), 5, "benjamin.turner@example.com", "Benjamin Turner", "Paid", new DateTime(2024, 8, 31, 16, 14, 22, 181, DateTimeKind.Local).AddTicks(5347), 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4161), new DateTime(2024, 9, 15, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 9, 25, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 9, 8, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 9, 17, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 9, 6, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Rate", "Sqft" },
                values: new object[] { "Private Beach, Beachfront View, Outdoor Shower", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4079), "A beachfront villa with a private beach, perfect for a romantic getaway or a family vacation.", "Beachfront", "Beachfront Villa", 400.0, 800 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Rate" },
                values: new object[] { "Kids' Play Area, Game Room, Large Pool", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4081), "A family-friendly villa with a kids' play area, game room, and a large swimming pool.", "Suburbs", "Family Villa", 350.0 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Mountain View, Nature Trail, Meditation Area", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4083), "A villa nestled in the mountains, offering a serene environment and stunning views of nature.", "Mountain Range", "Mountain Villa", 4, 300.0, 750 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amenity", "CreatedDate", "Details", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Lake View, Private Dock, Water Activities", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4085), "A villa overlooking a tranquil lake, with a private dock and water activities for guests.", "Lakeside", "Lakeview Villa", 6, 400.0, 850 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Botanical Garden, Greenhouse, Outdoor Dining", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4087), "A villa surrounded by lush gardens, with a botanical garden, greenhouse, and outdoor dining area.", true, "Garden City", "Garden Villa", 8, 450.0, 1000 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amenity", "CreatedDate", "Details", "IsAvailable", "Location", "Name", "Rate", "Sqft" },
                values: new object[] { "Fishing, Boating, Riverside Dining", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4089), "A villa by the riverside, offering fishing, boating, and riverside dining experiences.", false, "Riverside", "Riverside Villa", 350.0, 800 });
        }
    }
}
