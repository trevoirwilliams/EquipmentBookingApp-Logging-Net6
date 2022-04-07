using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentBookingApp.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 1, "tools", "Secure loose objects with minimal effort. ", "Hammer", 69.989999999999995 });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 2, "tools", "Tighten loose nuts and bolts. ", "Wrench", 49.990000000000002 });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 3, "tools", "Lift any item, no matter how heavy. ", "Pulley", 64.989999999999995 });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[] { 4, "tools", "Tighten any screw professionaly. ", "Pliers", 79.989999999999995 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}
