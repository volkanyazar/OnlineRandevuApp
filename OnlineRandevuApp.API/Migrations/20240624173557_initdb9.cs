using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Department_HospitalId",
                table: "Department",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Hospital_HospitalId",
                table: "Department",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Hospital_HospitalId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_HospitalId",
                table: "Department");
        }
    }
}
