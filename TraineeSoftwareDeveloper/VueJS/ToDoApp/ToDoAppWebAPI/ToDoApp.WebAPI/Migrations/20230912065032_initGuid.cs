using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Note",
                keyColumn: "Id",
                keyValue: new Guid("52dd194f-2c09-4a6f-a842-a4397864885c"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Note",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Note",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("9a19453d-75d1-417c-b28c-33b8a33a2103"), "My First Note at 9/12/2023 11:50:32 AM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Note",
                keyColumn: "Id",
                keyValue: new Guid("9a19453d-75d1-417c-b28c-33b8a33a2103"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Note",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Note",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("52dd194f-2c09-4a6f-a842-a4397864885c"), "My First Note at 9/12/2023 10:17:36 AM" });
        }
    }
}
