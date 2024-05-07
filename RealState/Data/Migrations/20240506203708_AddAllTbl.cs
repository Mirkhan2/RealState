using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estate_CategoryModel_CategoryId",
                table: "Estate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estate_Category_CategoryId",
                table: "Estate",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estate_Category_CategoryId",
                table: "Estate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "CategoryModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Estate_CategoryModel_CategoryId",
                table: "Estate",
                column: "CategoryId",
                principalTable: "CategoryModel",
                principalColumn: "Id");
        }
    }
}
