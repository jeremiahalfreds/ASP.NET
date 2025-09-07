using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDiary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "CreatedAt", "Description", "Title" },
                values: new object[] { 21, new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shopping at the biggest mall in Istanbul is amazing.", "Went Shopping" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
