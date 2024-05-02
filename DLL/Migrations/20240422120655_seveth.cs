using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLL.Migrations
{
    /// <inheritdoc />
    public partial class seveth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdSpecs_Products_ProductId",
                table: "ProdSpecs");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProdSpecs",
                newName: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdSpecs_Categories_CategoryId",
                table: "ProdSpecs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdSpecs_Categories_CategoryId",
                table: "ProdSpecs");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ProdSpecs",
                newName: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdSpecs_Products_ProductId",
                table: "ProdSpecs",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
