using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeduEcommerce.Migrations
{
    public partial class RenameManufactureIdToManufacturerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManufactureId",
                table: "AppPromotionManufacturers",
                newName: "ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "ManufactureId",
                table: "AppProducts",
                newName: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "AppPromotionManufacturers",
                newName: "ManufactureId");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "AppProducts",
                newName: "ManufactureId");
        }
    }
}
