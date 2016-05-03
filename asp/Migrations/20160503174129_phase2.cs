using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace asp.Migrations
{
    public partial class phase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Stops", table: "Trip");
            migrationBuilder.CreateTable(
                name: "Stop",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    TripID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stop_Trip_TripID",
                        column: x => x.TripID,
                        principalTable: "Trip",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trip",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Trip",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Trip",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Stop");
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trip",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Trip",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Trip",
                nullable: false);
            migrationBuilder.AddColumn<string>(
                name: "Stops",
                table: "Trip",
                nullable: true);
        }
    }
}
