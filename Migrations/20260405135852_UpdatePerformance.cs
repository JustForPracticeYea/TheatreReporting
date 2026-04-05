using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreReportingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePerformance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountTickSoldCashOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountTickSoldCashOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountTickSoldNonCashOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountTickSoldNonCashOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumTickSoldCashOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumTickSoldCashOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumTickSoldNonCashOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumTickSoldNonCashOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldInOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmountTickSoldOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumTickSoldInOffice",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumTickSoldOnline",
                table: "Performances",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountTickSoldCashOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AmountTickSoldCashOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AmountTickSoldNonCashOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AmountTickSoldNonCashOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "NumTickSoldCashOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "NumTickSoldCashOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "NumTickSoldNonCashOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "NumTickSoldNonCashOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldInOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalAmountTickSoldOnline",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalNumTickSoldInOffice",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "TotalNumTickSoldOnline",
                table: "Performances");
        }
    }
}
