using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_OnSiteLocation_OnSiteId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_StationarLocation_StationaryId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_TourLocation_TourId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourLocation",
                table: "TourLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationarLocation",
                table: "StationarLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnSiteLocation",
                table: "OnSiteLocation");

            migrationBuilder.RenameTable(
                name: "TourLocation",
                newName: "TourLocations");

            migrationBuilder.RenameTable(
                name: "StationarLocation",
                newName: "StationarLocations");

            migrationBuilder.RenameTable(
                name: "OnSiteLocation",
                newName: "OnSiteLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourLocations",
                table: "TourLocations",
                column: "TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationarLocations",
                table: "StationarLocations",
                column: "StationarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnSiteLocations",
                table: "OnSiteLocations",
                column: "OnSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_OnSiteLocations_OnSiteId",
                table: "Performances",
                column: "OnSiteId",
                principalTable: "OnSiteLocations",
                principalColumn: "OnSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_StationarLocations_StationaryId",
                table: "Performances",
                column: "StationaryId",
                principalTable: "StationarLocations",
                principalColumn: "StationarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_TourLocations_TourId",
                table: "Performances",
                column: "TourId",
                principalTable: "TourLocations",
                principalColumn: "TourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_OnSiteLocations_OnSiteId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_StationarLocations_StationaryId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_TourLocations_TourId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourLocations",
                table: "TourLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationarLocations",
                table: "StationarLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnSiteLocations",
                table: "OnSiteLocations");

            migrationBuilder.RenameTable(
                name: "TourLocations",
                newName: "TourLocation");

            migrationBuilder.RenameTable(
                name: "StationarLocations",
                newName: "StationarLocation");

            migrationBuilder.RenameTable(
                name: "OnSiteLocations",
                newName: "OnSiteLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourLocation",
                table: "TourLocation",
                column: "TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationarLocation",
                table: "StationarLocation",
                column: "StationarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnSiteLocation",
                table: "OnSiteLocation",
                column: "OnSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_OnSiteLocation_OnSiteId",
                table: "Performances",
                column: "OnSiteId",
                principalTable: "OnSiteLocation",
                principalColumn: "OnSiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_StationarLocation_StationaryId",
                table: "Performances",
                column: "StationaryId",
                principalTable: "StationarLocation",
                principalColumn: "StationarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_TourLocation_TourId",
                table: "Performances",
                column: "TourId",
                principalTable: "TourLocation",
                principalColumn: "TourId");
        }
    }
}
