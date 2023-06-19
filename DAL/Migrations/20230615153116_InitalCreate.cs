using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AIRPORT_DATALIST",
                columns: table => new
                {
                    ID_AIRPORT_DATALIST = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FUNCTION = table.Column<string>(type: "text", nullable: false),
                    NAME = table.Column<string>(type: "text", nullable: false),
                    ICAO_CODE = table.Column<string>(type: "text", nullable: false),
                    IATA_CODE = table.Column<string>(type: "text", nullable: false),
                    PLANNED_RUNWAY = table.Column<string>(type: "text", nullable: false),
                    SUITABLE_PER_FROM = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SUITABLE_PER_UNTIL = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    REQ_HOR_VISIBILITY = table.Column<int>(type: "integer", nullable: false),
                    REQ_VER_VISIBILITY = table.Column<int>(type: "integer", nullable: false),
                    CON_HOR_VISIBILITY = table.Column<int>(type: "integer", nullable: false),
                    CON_VER_VISIBILITY = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRPORT_DATALIST", x => x.ID_AIRPORT_DATALIST);
                });

            migrationBuilder.CreateTable(
                name: "WEIGHT_HEADER",
                columns: table => new
                {
                    ID_WEIGHT_HEADER = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DRY_OPERATING_WEIGHT = table.Column<int>(type: "integer", nullable: false),
                    DRY_OPERATING_WEIGHT_UNIT = table.Column<string>(type: "text", nullable: false),
                    LOAD = table.Column<int>(type: "integer", nullable: false),
                    LOAD_UNIT = table.Column<int>(type: "integer", nullable: false),
                    ZERO_FUEL_WEIGHT_EW = table.Column<int>(type: "integer", nullable: false),
                    ZERO_FUEL_WEIGHT_SL = table.Column<int>(type: "integer", nullable: false),
                    TAKEOFF_EW = table.Column<int>(type: "integer", nullable: false),
                    TAKEOFF_OL = table.Column<int>(type: "integer", nullable: false),
                    TAKEOFF_SL = table.Column<int>(type: "integer", nullable: false),
                    TAKEOFF_REASON = table.Column<string>(type: "text", nullable: false),
                    LANDING_EW = table.Column<int>(type: "integer", nullable: false),
                    LANDING_OL = table.Column<int>(type: "integer", nullable: false),
                    LANDING_SL = table.Column<int>(type: "integer", nullable: false),
                    WEIGHT_HEADER_EXTENSION = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEIGHT_HEADER", x => x.ID_WEIGHT_HEADER);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AIRPORT_DATALIST");

            migrationBuilder.DropTable(
                name: "WEIGHT_HEADER");
        }
    }
}
