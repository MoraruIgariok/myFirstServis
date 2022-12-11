using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstShop.Migrations
{
    /// <inheritdoc />
    public partial class deleteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsDetails_ProductDetailsId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductsDetails");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductDetailsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDetailsId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ProductsDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    PriceUnit = table.Column<decimal>(type: "decimal(19,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailsId",
                table: "Products",
                column: "ProductDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsDetails_ProductDetailsId",
                table: "Products",
                column: "ProductDetailsId",
                principalTable: "ProductsDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
