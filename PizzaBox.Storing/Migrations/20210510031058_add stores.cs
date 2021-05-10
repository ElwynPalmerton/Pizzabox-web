using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addstores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AStore",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AStore", x => x.EntityId);
                });

            migrationBuilder.InsertData(
                table: "AStore",
                columns: new[] { "EntityId", "Discriminator", "Name" },
                values: new object[] { 1L, "ChicagoStore", "Chitown Main Street" });

            migrationBuilder.InsertData(
                table: "AStore",
                columns: new[] { "EntityId", "Discriminator", "Name" },
                values: new object[] { 2L, "NewYorkStore", "Big Apple" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AStore");
        }
    }
}
