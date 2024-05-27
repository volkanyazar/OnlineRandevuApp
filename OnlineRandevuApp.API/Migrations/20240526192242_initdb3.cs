using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Randevous",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Randevous_DoctorId",
                table: "Randevous",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevous_Doctor_DoctorId",
                table: "Randevous",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevous_Doctor_DoctorId",
                table: "Randevous");

            migrationBuilder.DropIndex(
                name: "IX_Randevous_DoctorId",
                table: "Randevous");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Randevous");
        }
    }
}