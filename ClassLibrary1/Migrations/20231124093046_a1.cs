using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_songlists_singerlists_singerlistsingerid",
                table: "songlists");

            migrationBuilder.DropIndex(
                name: "IX_songlists_singerlistsingerid",
                table: "songlists");

            migrationBuilder.DropColumn(
                name: "singerlistsingerid",
                table: "songlists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "singerlistsingerid",
                table: "songlists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_songlists_singerlistsingerid",
                table: "songlists",
                column: "singerlistsingerid");

            migrationBuilder.AddForeignKey(
                name: "FK_songlists_singerlists_singerlistsingerid",
                table: "songlists",
                column: "singerlistsingerid",
                principalTable: "singerlists",
                principalColumn: "singerid");
        }
    }
}
