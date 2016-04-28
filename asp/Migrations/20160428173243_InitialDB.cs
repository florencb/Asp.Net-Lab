using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace asp.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Stops = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Trip");
        }
    }
}
