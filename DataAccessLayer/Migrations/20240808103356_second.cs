using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSpentFuel",
                table: "TrackingDataForSTDs",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Speed",
                table: "TrackingDataForSTDs",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Odometer",
                table: "TrackingDataForSTDs",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelLevel",
                table: "TrackingDataForSTDs",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "COG",
                table: "TrackingDataForSTDs",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Speed",
                table: "TrackingDataForACCs",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "TrackingDataForACCs",
                type: "decimal(10,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "TrackingDataForACCs",
                type: "decimal(11,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "COG",
                table: "TrackingDataForACCs",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altitude",
                table: "TrackingDataForACCs",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccZ",
                table: "TrackingDataForACCs",
                type: "decimal(6,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccY",
                table: "TrackingDataForACCs",
                type: "decimal(6,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccX",
                table: "TrackingDataForACCs",
                type: "decimal(6,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSpentFuel",
                table: "TrackingDataForSTDs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Speed",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Odometer",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FuelLevel",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "COG",
                table: "TrackingDataForSTDs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altitude",
                table: "TrackingDataForSTDs",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Speed",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "TrackingDataForACCs",
                type: "decimal(10,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "TrackingDataForACCs",
                type: "decimal(11,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "COG",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altitude",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccZ",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccY",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AccX",
                table: "TrackingDataForACCs",
                type: "decimal(6,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)");
        }
    }
}
