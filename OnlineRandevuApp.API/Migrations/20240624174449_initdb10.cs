using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HospitalCode",
                table: "Hospital",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalCode",
                table: "Hospital");
        }
    }
}
