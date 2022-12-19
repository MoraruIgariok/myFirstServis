using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstShop.Migrations
{
    /// <inheritdoc />
    public partial class editcolum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Clients_ClientId",
                table: "BasketProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Products_ProductId",
                table: "BasketProducts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BasketProducts",
                newName: "ProductIdId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "BasketProducts",
                newName: "ClientIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketProducts_ProductId",
                table: "BasketProducts",
                newName: "IX_BasketProducts_ProductIdId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketProducts_ClientId",
                table: "BasketProducts",
                newName: "IX_BasketProducts_ClientIdId");

            migrationBuilder.AlterColumn<string>(
                name: "ShopeName",
                table: "BasketProducts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Clients_ClientIdId",
                table: "BasketProducts",
                column: "ClientIdId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Products_ProductIdId",
                table: "BasketProducts",
                column: "ProductIdId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Clients_ClientIdId",
                table: "BasketProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Products_ProductIdId",
                table: "BasketProducts");

            migrationBuilder.RenameColumn(
                name: "ProductIdId",
                table: "BasketProducts",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ClientIdId",
                table: "BasketProducts",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketProducts_ProductIdId",
                table: "BasketProducts",
                newName: "IX_BasketProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketProducts_ClientIdId",
                table: "BasketProducts",
                newName: "IX_BasketProducts_ClientId");

            migrationBuilder.AlterColumn<string>(
                name: "ShopeName",
                table: "BasketProducts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Clients_ClientId",
                table: "BasketProducts",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Products_ProductId",
                table: "BasketProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
