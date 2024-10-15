using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FullstackBeatsBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    About = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HostId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Rsvps = table.Column<int>(type: "integer", nullable: false),
                    AirDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_Users_HostId",
                        column: x => x.HostId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserShow",
                columns: table => new
                {
                    AttendeeId = table.Column<int>(type: "integer", nullable: false),
                    WatchShowId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShow", x => new { x.AttendeeId, x.WatchShowId });
                    table.ForeignKey(
                        name: "FK_UserShow_Shows_WatchShowId",
                        column: x => x.WatchShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserShow_Users_AttendeeId",
                        column: x => x.AttendeeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Music" },
                    { 2, "Comedy" },
                    { 3, "Education" },
                    { 4, "Gaming" },
                    { 5, "Presentation" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "Email", "Image", "Uid", "UserName" },
                values: new object[,]
                {
                    { 1, "Loves exploring new gadgets and technologies.", "noahcurryallenpa@gmail.com", "tech_guru.png", "fgikJy5FMVXz3M8t5DkBSzUp64i2", "Noah" },
                    { 2, "Avid music lover with a passion for discovering new artists.", "deramust@gmail.com", "music_maven.jpg", "MJ1mbp0Gm1dnXYqECtMh3PH5dHy2", "Toren" },
                    { 3, "Movie enthusiast and amateur filmmaker.", "filmbuff@example.com", "film_buff.png", "ghi789", "film_buff" }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "AirDate", "CategoryId", "Description", "HostId", "Image", "Name", "Rsvps" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "How artificial intelligence is changing the world.", 1, "ai_revolution.jpg", "AI Revolution", 85 },
                    { 4, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Exclusive interviews with top music producers.", 2, "behind_the_beats.jpg", "Behind the Beats", 150 },
                    { 6, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Spotlighting indie filmmakers and their work.", 3, "indie_scene.jpg", "The Indie Scene", 110 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_HostId",
                table: "Shows",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserShow_WatchShowId",
                table: "UserShow",
                column: "WatchShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserShow");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
