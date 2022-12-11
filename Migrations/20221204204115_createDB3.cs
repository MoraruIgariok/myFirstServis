using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstShop.Migrations
{
    /// <inheritdoc />
    public partial class createDB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price_Unit",
                table: "ProductsDetails",
                newName: "PriceUnit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceUnit",
                table: "ProductsDetails",
                newName: "Price_Unit");
        }
    }
}
