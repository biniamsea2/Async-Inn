using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class fixingdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Room",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                keyValue: 3,
                column: "Name",
                value: "Room Lannister");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Room",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Boom Boom");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "No Boom Boom");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Honeymoon");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Lonely");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "R2D2");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 6,
                column: "Name",
                value: "Friends");
        }
    }
}
