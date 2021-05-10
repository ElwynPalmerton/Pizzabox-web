using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addpriceseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 3.00m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 4.00m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 5.00m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 0m);
        }
    }
}
