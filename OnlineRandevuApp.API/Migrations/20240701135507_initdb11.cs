using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Doctor",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndHour",
                table: "Doctor",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Doctor",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartHour",
                table: "Doctor",
                type: "timestamp without time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "EndHour",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "StartHour",
                table: "Doctor");
        }
    }
}
