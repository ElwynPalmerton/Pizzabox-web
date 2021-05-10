using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addtoppingpriceseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 3.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 4.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L,
                column: "Price",
                value: 6.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L,
                column: "Price",
                value: 4.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 7L,
                column: "Price",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 8L,
                column: "Price",
                value: 2.00m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 9L,
                column: "Price",
                value: 4.00m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 7L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 8L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 9L,
                column: "Price",
                value: 0m);
        }
    }
}
