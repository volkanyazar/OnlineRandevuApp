using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Department_DepartmanId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_DepartmanId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "DepartmanId",
                table: "Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Department_DepartmentId",
                table: "Doctor",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Department_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "DepartmanId",
                table: "Doctor",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartmanId",
                table: "Doctor",
                column: "DepartmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Department_DepartmanId",
                table: "Doctor",
                column: "DepartmanId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
