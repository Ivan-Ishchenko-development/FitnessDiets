using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessDiets.Data.Migrations
{
    public partial class _initfood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FoodName = table.Column<string>(nullable: false),
                    Eatenfood = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Eatenfood", "FoodName" },
                values: new object[] { new Guid("6da261ff-d98a-4132-a33e-509858c0ce31"), 400, "Борщ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
