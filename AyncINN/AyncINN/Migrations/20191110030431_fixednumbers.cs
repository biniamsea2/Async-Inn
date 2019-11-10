using Microsoft.EntityFrameworkCore.Migrations;

namespace AyncINN.Migrations
{
    public partial class fixednumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "(206)985-8493");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "(206)584-3674");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: "(212)673-6483");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: "(786)385-7912");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: "(213)789-3841");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6,
                column: "Phone",
                value: "(510)796-3984");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Hotel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: 1234567767);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: 1234567767);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: 1644563592);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: 1812673541);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: 1457893245);

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6,
                column: "Phone",
                value: 1812673541);
        }
    }
}
