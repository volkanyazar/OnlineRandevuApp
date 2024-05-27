using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Randevous",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hour",
                table: "Randevous",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Randevous");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "Randevous");
        }
    }
}