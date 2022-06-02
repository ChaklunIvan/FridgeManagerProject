using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class Remove_UserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8c2f458-16f7-41fd-8f2f-dd8e717d0997"));

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { new Guid("d8c2f458-16f7-41fd-8f2f-dd8e717d0997"), "admin@gmail.com", "Admin", "123" });
        }
    }
}
