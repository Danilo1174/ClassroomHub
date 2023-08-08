using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class corrigido_tabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Modules_ClassId",
                table: "Modules");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ClassId",
                table: "Modules",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Modules_ClassId",
                table: "Modules");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ClassId",
                table: "Modules",
                column: "ClassId",
                unique: true);
        }
    }
}
