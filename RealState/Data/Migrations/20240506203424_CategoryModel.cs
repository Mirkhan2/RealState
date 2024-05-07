using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealState.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Estate",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Estate",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Estate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estate_CategoryId",
                table: "Estate",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estate_CategoryModel_CategoryId",
                table: "Estate",
                column: "CategoryId",
                principalTable: "CategoryModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estate_CategoryModel_CategoryId",
                table: "Estate");

            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropIndex(
                name: "IX_Estate_CategoryId",
                table: "Estate");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Estate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Estate",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Estate",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
