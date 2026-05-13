using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondUpdateViewerCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ViewerCategories",
                newName: "ViewerCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PerformanceViewerCategories",
                newName: "PerformanceViewerCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ViewerCategoryId",
                table: "ViewerCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PerformanceViewerCategoryId",
                table: "PerformanceViewerCategories",
                newName: "Id");
        }
    }
}
