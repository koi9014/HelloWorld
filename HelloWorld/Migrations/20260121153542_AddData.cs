using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HelloWorld.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TOPMenu",
                columns: new[] { "TOPMenuId", "Icon", "Name", "Orders", "Url" },
                values: new object[,]
                {
                    { new Guid("55adf662-0e1a-4689-b4ed-e5a83e744746"), "Icon2", "回首頁", 2, "a2" },
                    { new Guid("5c20aef8-a54c-4bb9-a10b-818ea58e4325"), "Icon5", "市長信箱", 5, "a5" },
                    { new Guid("839fe886-5a13-4f72-af42-01edc363436c"), "Icon3", "English", 3, "a3" },
                    { new Guid("83d37ac1-d155-453f-83fb-8b838bb5e727"), "Icon1", "網站導覽", 1, "a1" },
                    { new Guid("85c418f5-15ea-496b-be60-f741e088ea2b"), "Icon4", "雙語詞彙", 4, "a4" },
                    { new Guid("c3fb8eed-f7b5-43ff-9531-8d5058f19280"), "Icon6", "洽公導覽", 6, "a6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("55adf662-0e1a-4689-b4ed-e5a83e744746"));

            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("5c20aef8-a54c-4bb9-a10b-818ea58e4325"));

            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("839fe886-5a13-4f72-af42-01edc363436c"));

            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("83d37ac1-d155-453f-83fb-8b838bb5e727"));

            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("85c418f5-15ea-496b-be60-f741e088ea2b"));

            migrationBuilder.DeleteData(
                table: "TOPMenu",
                keyColumn: "TOPMenuId",
                keyValue: new Guid("c3fb8eed-f7b5-43ff-9531-8d5058f19280"));
        }
    }
}
