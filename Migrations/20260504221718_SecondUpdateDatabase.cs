using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondUpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "Reports",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TotalNumTickSoldOnline",
                table: "Performances",
                newName: "TotalRealAmountTickSoldInOfficeOnline");

            migrationBuilder.RenameColumn(
                name: "TotalNumTickSoldInOffice",
                table: "Performances",
                newName: "TotalNumTickSoldNonCashOfficeOnline");

            migrationBuilder.RenameColumn(
                name: "TotalAmountTickSoldOnline",
                table: "Performances",
                newName: "TotalNumTickSoldNonCashInOfficeOnline");

            migrationBuilder.RenameColumn(
                name: "TotalAmountTickSoldInOffice",
                table: "Performances",
                newName: "TotalNumTickSoldCashOfficeOnline");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Performances",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Reports",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractDate",
                table: "PlayAuthors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ContractIsActive",
                table: "PlayAuthors",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ContractNumber",
                table: "PlayAuthors",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExcludedDatesJson",
                table: "PlayAuthors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AllAmountTickSoldInOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AllAmountTickSoldOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AllNumTickSoldInOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AllNumTickSoldOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditDate",
                table: "Performances",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxRevenue",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnSiteId",
                table: "Performances",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationaryId",
                table: "Performances",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalAllAmountTickSoldInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAllNumTickSoldInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountFundsRetCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountFundsRetNonCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldCashOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldNonCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldNonCashOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumTickRetCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumTickRetNonCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumTickSoldCashInOfficeOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Performances",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Performances",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Fathername",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "OnSiteLocation",
                columns: table => new
                {
                    OnSiteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TownName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    SettlementType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Region = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnSiteLocation", x => x.OnSiteId);
                });

            migrationBuilder.CreateTable(
                name: "StationarLocation",
                columns: table => new
                {
                    StationarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocationName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationarLocation", x => x.StationarId);
                });

            migrationBuilder.CreateTable(
                name: "TourLocation",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TownName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLocation", x => x.TourId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_OnSiteId",
                table: "Performances",
                column: "OnSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_StationaryId",
                table: "Performances",
                column: "StationaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_TourId",
                table: "Performances",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_UserId",
                table: "Performances",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_AspNetUsers_UserId",
                table: "Performances",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_AspNetUsers_UserId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_OnSiteLocation_OnSiteId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_StationarLocation_StationaryId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_TourLocation_TourId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "OnSiteLocation");

            migrationBuilder.DropTable(
                name: "StationarLocation");

            migrationBuilder.DropTable(
                name: "TourLocation");

            migrationBuilder.DropIndex(
                name: "IX_Reports_UserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Performances_OnSiteId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_StationaryId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_TourId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_UserId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ContractDate",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "ContractIsActive",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "ExcludedDatesJson",
                table: "PlayAuthors");

            migrationBuilder.DropColumn(
                name: "AllAmountTickSoldInOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AllAmountTickSoldOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AllNumTickSoldInOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AllNumTickSoldOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "EditDate",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "MaxRevenue",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "OnSiteId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "StationaryId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAllAmountTickSoldInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAllNumTickSoldInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountFundsRetCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountFundsRetNonCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldCashOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldNonCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldNonCashOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalNumTickRetCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalNumTickRetNonCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalNumTickSoldCashInOfficeOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Performances");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reports",
                newName: "FilePath");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Performances",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "TotalRealAmountTickSoldInOfficeOnline",
                table: "Performances",
                newName: "TotalNumTickSoldOnline");

            migrationBuilder.RenameColumn(
                name: "TotalNumTickSoldNonCashOfficeOnline",
                table: "Performances",
                newName: "TotalNumTickSoldInOffice");

            migrationBuilder.RenameColumn(
                name: "TotalNumTickSoldNonCashInOfficeOnline",
                table: "Performances",
                newName: "TotalAmountTickSoldOnline");

            migrationBuilder.RenameColumn(
                name: "TotalNumTickSoldCashOfficeOnline",
                table: "Performances",
                newName: "TotalAmountTickSoldInOffice");

            migrationBuilder.AlterColumn<string>(
                name: "Fathername",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
