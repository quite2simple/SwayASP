using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwayASP.Migrations
{
    /// <inheritdoc />
    public partial class Try2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<int>(
                name: "Depth",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpeningYear",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PlatformCount",
                table: "Stations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "PositionX",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionY",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "TrackCount",
                table: "Stations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "HasBranches",
                table: "Lines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OpeningYear",
                table: "Lines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "StationCount",
                table: "Lines",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "OpeningYear",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "PlatformCount",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "PositionX",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "PositionY",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "TrackCount",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "HasBranches",
                table: "Lines");

            migrationBuilder.DropColumn(
                name: "OpeningYear",
                table: "Lines");

            migrationBuilder.DropColumn(
                name: "StationCount",
                table: "Lines");
            
        }
    }
}
