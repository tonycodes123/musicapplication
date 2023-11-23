using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albumlist");

            migrationBuilder.DropTable(
                name: "singerlist");

            migrationBuilder.DropTable(
                name: "songlist");

            migrationBuilder.CreateTable(
                name: "albumlists",
                columns: table => new
                {
                    albumid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    albumname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    albumimage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albumlists", x => x.albumid);
                });

            migrationBuilder.CreateTable(
                name: "songlists",
                columns: table => new
                {
                    songid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    songname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    songreleasedate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_songlists", x => x.songid);
                });

            migrationBuilder.CreateTable(
                name: "singerlists",
                columns: table => new
                {
                    singerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    singername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    singerimage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    songlistsongid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singerlists", x => x.singerid);
                    table.ForeignKey(
                        name: "FK_singerlists_songlists_songlistsongid",
                        column: x => x.songlistsongid,
                        principalTable: "songlists",
                        principalColumn: "songid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_singerlists_songlistsongid",
                table: "singerlists",
                column: "songlistsongid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albumlists");

            migrationBuilder.DropTable(
                name: "singerlists");

            migrationBuilder.DropTable(
                name: "songlists");

            migrationBuilder.CreateTable(
                name: "albumlist",
                columns: table => new
                {
                    albumid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    albumimage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    albumname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albumlist", x => x.albumid);
                });

            migrationBuilder.CreateTable(
                name: "songlist",
                columns: table => new
                {
                    songid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    songname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    songreleasedate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_songlist", x => x.songid);
                });

            migrationBuilder.CreateTable(
                name: "singerlist",
                columns: table => new
                {
                    singerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    singerimage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    singername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    songlistsongid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singerlist", x => x.singerid);
                    table.ForeignKey(
                        name: "FK_singerlist_songlist_songlistsongid",
                        column: x => x.songlistsongid,
                        principalTable: "songlist",
                        principalColumn: "songid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_singerlist_songlistsongid",
                table: "singerlist",
                column: "songlistsongid");
        }
    }
}
