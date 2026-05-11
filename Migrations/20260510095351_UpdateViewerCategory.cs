using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateViewerCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViewerCategories_Performances_PerformanceId",
                table: "ViewerCategories");

            migrationBuilder.DropIndex(
                name: "IX_ViewerCategories_PerformanceId",
                table: "ViewerCategories");

            migrationBuilder.DropColumn(
                name: "PerformanceId",
                table: "ViewerCategories");

            migrationBuilder.DropColumn(
                name: "ViewerCount",
                table: "ViewerCategories");

            migrationBuilder.CreateTable(
                name: "PerformanceViewerCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ViewerCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PerformanceId = table.Column<int>(type: "INTEGER", nullable: false),
                    ViewerCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceViewerCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceViewerCategory_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "PerformanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerformanceViewerCategory_ViewerCategories_ViewerCategoryId",
                        column: x => x.ViewerCategoryId,
                        principalTable: "ViewerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceViewerCategory_PerformanceId",
                table: "PerformanceViewerCategory",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceViewerCategory_ViewerCategoryId",
                table: "PerformanceViewerCategory",
                column: "ViewerCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerformanceViewerCategory");

            migrationBuilder.AddColumn<int>(
                name: "PerformanceId",
                table: "ViewerCategories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViewerCount",
                table: "ViewerCategories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ViewerCategories_PerformanceId",
                table: "ViewerCategories",
                column: "PerformanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ViewerCategories_Performances_PerformanceId",
                table: "ViewerCategories",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "PerformanceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
