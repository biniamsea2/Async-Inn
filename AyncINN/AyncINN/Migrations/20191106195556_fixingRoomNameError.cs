using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class fixingRoomNameError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "House Lannister");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Room Lannister");
        }
    }
}
