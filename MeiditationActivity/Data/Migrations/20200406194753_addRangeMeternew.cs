using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeiditationActivity.Data.Migrations
{
    public partial class addRangeMeternew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RangeMeters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sleepingHour = table.Column<int>(nullable: false),
                    PhysicalLoad = table.Column<int>(nullable: false),
                    SleepQuality = table.Column<string>(nullable: true),
                    weight = table.Column<double>(nullable: false),
                    MentalStausRate = table.Column<int>(nullable: false),
                    PhysicalStatusRate = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Stressed = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeMeters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RangeMeters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RangeMeters_UserId",
                table: "RangeMeters",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RangeMeters");
        }
    }
}
