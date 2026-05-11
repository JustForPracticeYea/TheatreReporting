using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class ThirdUpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractIsActive",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "ExcludedDatesJson",
                table: "PlayAuthors");

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEndDate",
                table: "PlayAuthors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AmountImplementationPercentage",
                table: "Performances",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingCapacity",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingRevenue",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TicketImplementationPercentage",
                table: "Performances",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ViewerCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    ViewerCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PerformanceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewerCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewerCategories_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "PerformanceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ViewerCategories_PerformanceId",
                table: "ViewerCategories",
                column: "PerformanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ViewerCategories");

            migrationBuilder.DropColumn(
                name: "ContractEndDate",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "AmountImplementationPercentage",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "RemainingCapacity",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "RemainingRevenue",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TicketImplementationPercentage",
                table: "Performances");

            migrationBuilder.AddColumn<bool>(
                name: "ContractIsActive",
                table: "PlayAuthors",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExcludedDatesJson",
                table: "PlayAuthors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
