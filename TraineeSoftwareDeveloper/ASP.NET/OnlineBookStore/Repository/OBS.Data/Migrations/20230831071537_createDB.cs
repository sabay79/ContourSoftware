using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OBS.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "049885b7-09fc-412b-a8ce-964cf79d8304");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5adf1814-edf9-4262-9cf4-299d12ae5155");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75ac11a1-9013-4482-b63b-bb19bc1e7e99");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbc4de62-3837-4974-ac6a-e5bb4a57edc9", "1", "Admin", "Admin" },
                    { "c395d8ac-02c4-4393-8dcb-c71bc8f2dad1", "3", "HR", "HR" },
                    { "e33e5f7c-1c5b-4bb7-9e95-7ce2345820c0", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbc4de62-3837-4974-ac6a-e5bb4a57edc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c395d8ac-02c4-4393-8dcb-c71bc8f2dad1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e33e5f7c-1c5b-4bb7-9e95-7ce2345820c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "049885b7-09fc-412b-a8ce-964cf79d8304", "2", "User", "User" },
                    { "5adf1814-edf9-4262-9cf4-299d12ae5155", "1", "Admin", "Admin" },
                    { "75ac11a1-9013-4482-b63b-bb19bc1e7e99", "3", "HR", "HR" }
                });
        }
    }
}
