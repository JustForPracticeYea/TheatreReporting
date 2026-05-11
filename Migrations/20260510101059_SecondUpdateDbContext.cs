using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondUpdateDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceViewerCategory_Performances_PerformanceId",
                table: "PerformanceViewerCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceViewerCategory_ViewerCategories_ViewerCategoryId",
                table: "PerformanceViewerCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformanceViewerCategory",
                table: "PerformanceViewerCategory");

            migrationBuilder.RenameTable(
                name: "PerformanceViewerCategory",
                newName: "PerformanceViewerCategories");

            migrationBuilder.RenameIndex(
                name: "IX_PerformanceViewerCategory_ViewerCategoryId",
                table: "PerformanceViewerCategories",
                newName: "IX_PerformanceViewerCategories_ViewerCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PerformanceViewerCategory_PerformanceId",
                table: "PerformanceViewerCategories",
                newName: "IX_PerformanceViewerCategories_PerformanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformanceViewerCategories",
                table: "PerformanceViewerCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceViewerCategories_Performances_PerformanceId",
                table: "PerformanceViewerCategories",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "PerformanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceViewerCategories_ViewerCategories_ViewerCategoryId",
                table: "PerformanceViewerCategories",
                column: "ViewerCategoryId",
                principalTable: "ViewerCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceViewerCategories_Performances_PerformanceId",
                table: "PerformanceViewerCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceViewerCategories_ViewerCategories_ViewerCategoryId",
                table: "PerformanceViewerCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerformanceViewerCategories",
                table: "PerformanceViewerCategories");

            migrationBuilder.RenameTable(
                name: "PerformanceViewerCategories",
                newName: "PerformanceViewerCategory");

            migrationBuilder.RenameIndex(
                name: "IX_PerformanceViewerCategories_ViewerCategoryId",
                table: "PerformanceViewerCategory",
                newName: "IX_PerformanceViewerCategory_ViewerCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PerformanceViewerCategories_PerformanceId",
                table: "PerformanceViewerCategory",
                newName: "IX_PerformanceViewerCategory_PerformanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerformanceViewerCategory",
                table: "PerformanceViewerCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceViewerCategory_Performances_PerformanceId",
                table: "PerformanceViewerCategory",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "PerformanceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceViewerCategory_ViewerCategories_ViewerCategoryId",
                table: "PerformanceViewerCategory",
                column: "ViewerCategoryId",
                principalTable: "ViewerCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
