using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class AddRolesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9689c3a2-be12-497f-be5e-007c247144ba", "ea812d01-e981-4de6-87c2-1b544676d650", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c866dc3-bb63-461d-b974-b49acaca4627", "e9a3a9f7-7085-47b6-b922-6e6d57aeb451", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c866dc3-bb63-461d-b974-b49acaca4627");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9689c3a2-be12-497f-be5e-007c247144ba");
        }
    }
}
