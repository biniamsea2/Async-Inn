using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class fixederror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Layout", "Name" },
                values: new object[] { 2, "Honeymoon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Layout", "Name" },
                values: new object[] { 3, "Boom Boom" });
        }
    }
}
