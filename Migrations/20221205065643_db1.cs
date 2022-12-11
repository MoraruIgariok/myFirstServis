using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstShop.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count_Product",
                table: "ProductsDetails",
                newName: "CountProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountProduct",
                table: "ProductsDetails",
                newName: "Count_Product");
        }
    }
}
