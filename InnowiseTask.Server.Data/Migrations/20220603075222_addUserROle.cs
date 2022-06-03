using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class addUserROle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c866dc3-bb63-461d-b974-b49acaca4627");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9689c3a2-be12-497f-be5e-007c247144ba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dab7b94-d7b0-4efb-b6e6-8c171cb02112", "dd0fc886-0516-4915-9ef4-487b97fff686", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3e0ee87-a182-491c-962d-bd57725d1d1f", "15af9404-1133-40e9-93c7-3c89a668fc58", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bddabb5-db78-4b52-98fa-bd1ca6b4e3b0", "e99135b2-097a-42d1-82ba-abea2db018a8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bddabb5-db78-4b52-98fa-bd1ca6b4e3b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dab7b94-d7b0-4efb-b6e6-8c171cb02112");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3e0ee87-a182-491c-962d-bd57725d1d1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9689c3a2-be12-497f-be5e-007c247144ba", "ea812d01-e981-4de6-87c2-1b544676d650", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c866dc3-bb63-461d-b974-b49acaca4627", "e9a3a9f7-7085-47b6-b922-6e6d57aeb451", "Administrator", "ADMINISTRATOR" });
        }
    }
}
