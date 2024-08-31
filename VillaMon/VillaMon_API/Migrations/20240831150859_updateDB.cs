using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaMon_API.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "IsAvailable", "Location", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, "Private Beach, Beachfront View, Outdoor Shower", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4079), "A beachfront villa with a private beach, perfect for a romantic getaway or a family vacation.", "https://dotnetmastery.com/bluevillaimages/villa6.jpg", true, "Beachfront", "Beachfront Villa", 4, 400.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Kids' Play Area, Game Room, Large Pool", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4081), "A family-friendly villa with a kids' play area, game room, and a large swimming pool.", "https://dotnetmastery.com/bluevillaimages/villa7.jpg", true, "Suburbs", "Family Villa", 6, 350.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Mountain View, Nature Trail, Meditation Area", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4083), "A villa nestled in the mountains, offering a serene environment and stunning views of nature.", "https://dotnetmastery.com/bluevillaimages/villa8.jpg", false, "Mountain Range", "Mountain Villa", 4, 300.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Lake View, Private Dock, Water Activities", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4085), "A villa overlooking a tranquil lake, with a private dock and water activities for guests.", "https://dotnetmastery.com/bluevillaimages/villa9.jpg", true, "Lakeside", "Lakeview Villa", 6, 400.0, 850, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Botanical Garden, Greenhouse, Outdoor Dining", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4087), "A villa surrounded by lush gardens, with a botanical garden, greenhouse, and outdoor dining area.", "https://dotnetmastery.com/bluevillaimages/villa10.jpg", true, "Garden City", "Garden Villa", 8, 450.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Fishing, Boating, Riverside Dining", new DateTime(2024, 8, 31, 16, 8, 59, 485, DateTimeKind.Local).AddTicks(4089), "A villa by the riverside, offering fishing, boating, and riverside dining experiences.", "https://dotnetmastery.com/bluevillaimages/villa11.jpg", false, "Riverside", "Riverside Villa", 4, 350.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 9, 15, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 9, 25, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2328), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 9, 8, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 9, 17, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 9, 6, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 1, 55, 46, 630, DateTimeKind.Local).AddTicks(2254));
        }
    }
}
