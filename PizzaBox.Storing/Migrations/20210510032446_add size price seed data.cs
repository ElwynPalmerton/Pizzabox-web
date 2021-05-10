using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addsizepriceseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 10.00m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 15.00m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 0m);
        }
    }
}
