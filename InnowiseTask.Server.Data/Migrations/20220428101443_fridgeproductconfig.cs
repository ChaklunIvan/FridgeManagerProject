using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class fridgeproductconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "FridgeId", "ProductId", "Id", "Quantity" },
                values: new object[,]
                {
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("458f0692-8ad3-45ce-9733-483e14579f9b"), 1 },
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("34b49f1a-6eca-4744-8d88-eaf1b3c38ec1"), 10 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("623b645c-a579-4ae1-9960-3b3a3dc00941"), 10 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("1c7906a9-26aa-48c7-9dd6-65c087ddbb1b"), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf") });
        }
    }
}
