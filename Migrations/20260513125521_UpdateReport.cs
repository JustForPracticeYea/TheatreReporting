using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Reports",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "FromPeriod",
                table: "Reports",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ToPeriod",
                table: "Reports",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Performances",
                type: "INTEGER",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "SettlementType",
                table: "OnSiteLocations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromPeriod",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ToPeriod",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Reports",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Performances",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SettlementType",
                table: "OnSiteLocations",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
