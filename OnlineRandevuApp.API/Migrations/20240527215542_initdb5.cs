using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRandevuApp.API.Migrations
{
    public partial class initdb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Department_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevous_Doctor_DoctorId",
                table: "Randevous");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Randevous",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevous_DoctorId",
                table: "Randevous",
                newName: "IX_Randevous_DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Department",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DoctorId",
                table: "Department",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Doctor_DoctorId",
                table: "Department",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevous_Department_DepartmentId",
                table: "Randevous",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Doctor_DoctorId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevous_Department_DepartmentId",
                table: "Randevous");

            migrationBuilder.DropIndex(
                name: "IX_Department_DoctorId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Randevous",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevous_DepartmentId",
                table: "Randevous",
                newName: "IX_Randevous_DoctorId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Doctor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Randevous_Doctor_DoctorId",
                table: "Randevous",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}