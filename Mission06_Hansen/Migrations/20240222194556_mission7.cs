using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission06_Hansen.Migrations
{
    /// <inheritdoc />
    public partial class mission7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Forms");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Forms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Forms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CopiedToPlex",
                table: "Forms",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "MovieId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Miscellaneuos" },
                    { 2, "Drama" },
                    { 3, "Television" },
                    { 4, "Horror/Suspense" },
                    { 5, "Comdedy" },
                    { 6, "Family" },
                    { 7, "Action/Adventure" },
                    { 8, "VHS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_CategoryId",
                table: "Forms",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Categories_CategoryId",
                table: "Forms",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Categories_CategoryId",
                table: "Forms");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_CategoryId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "Forms");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Forms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "Title");
        }
    }
}
