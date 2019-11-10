using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class changedRoomNameAndDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "House Stark");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "House Frey");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "House Tyrell");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "House Targaryen");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 6,
                column: "Name",
                value: "House Baratheon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Room Stark");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Room Frey");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Room Tyrell");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Room Targaryen");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 6,
                column: "Name",
                value: "Room Baratheon");
        }
    }
}
