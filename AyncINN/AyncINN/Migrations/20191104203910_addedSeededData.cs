using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class addedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Big Screen TV" },
                    { 2, "Mini Bar" },
                    { 3, "Hot tub" },
                    { 4, "AC" },
                    { 5, "Balcony with a view" },
                    { 6, "Wifi" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 6, "Oakland", "Cozy Motel", 1812673541, "CA", "13 Washington St" },
                    { 5, "Los Angeles", "Stars Inn", 1457893245, "CA", "32634 Santa Monica Blvd" },
                    { 4, "Miami", "Cozy Motel", 1812673541, "FL", "4282 52nd ave W" },
                    { 3, "New York City", "Sleep Well Inn", 1644563592, "NY", "5678 19th ave SW" },
                    { 2, "Seattle", "Rest Easy Inn", 1234567767, "WA", "1234 15th ave NE" },
                    { 1, "Seattle", "Rest Easy Inn", 1234567767, "WA", "1234 15th ave NE" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Boom Boom" },
                    { 2, 1, "No Boom Boom" },
                    { 3, 3, "Boom Boom" },
                    { 4, 1, "Lonely" },
                    { 5, 2, "R2D2" },
                    { 6, 3, "Friends" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
