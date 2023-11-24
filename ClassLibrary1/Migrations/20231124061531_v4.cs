using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_singerlists_songlists_songlistsongid",
                table: "singerlists");

            migrationBuilder.DropIndex(
                name: "IX_singerlists_songlistsongid",
                table: "singerlists");

            migrationBuilder.DropColumn(
                name: "songlistsongid",
                table: "singerlists");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "songlistsongid",
                table: "singerlists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_singerlists_songlistsongid",
                table: "singerlists",
                column: "songlistsongid");

            migrationBuilder.AddForeignKey(
                name: "FK_singerlists_songlists_songlistsongid",
                table: "singerlists",
                column: "songlistsongid",
                principalTable: "songlists",
                principalColumn: "songid");
        }
    }
}
