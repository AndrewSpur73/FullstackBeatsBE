using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullstackBeatsBE.Migrations
{
    public partial class CategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Users_HostId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows");

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "AirDate", "CategoryId", "Description", "HostId", "Image", "Name", "Rsvps" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Exploring the latest advancements in technology.", 1, "future_tech.jpg", "Future Tech", 120 },
                    { 3, new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "A live concert series featuring emerging artists.", 2, "soundwave_live.jpg", "Soundwave Live", 200 },
                    { 5, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "A deep dive into the history of filmmaking.", 3, "cinema_history.jpg", "Cinema History", 95 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Users_HostId",
                table: "Shows",
                column: "HostId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Users_HostId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows");

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows",
                column: "CategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Users_HostId",
                table: "Shows",
                column: "HostId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
