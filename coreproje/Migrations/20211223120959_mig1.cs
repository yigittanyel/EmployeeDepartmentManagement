using Microsoft.EntityFrameworkCore.Migrations;

namespace coreproje.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmanID",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departmanID",
                table: "Personels",
                column: "departmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_departmanID",
                table: "Personels",
                column: "departmanID",
                principalTable: "Departmans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_departmanID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_departmanID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "departmanID",
                table: "Personels");
        }
    }
}
