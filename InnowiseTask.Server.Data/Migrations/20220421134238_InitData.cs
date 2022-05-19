using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FridgeModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DefaultQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fridges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FridgeModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fridges_FridgeModels_FridgeModelId",
                        column: x => x.FridgeModelId,
                        principalTable: "FridgeModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FridgeProducts",
                columns: table => new
                {
                    FridgeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeProducts", x => new { x.FridgeId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_FridgeProducts_Fridges_FridgeId",
                        column: x => x.FridgeId,
                        principalTable: "Fridges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FridgeProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FridgeModels",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("919f36a2-0586-44e9-a67d-47d7bd519c79"), "Liebherr", 2020 },
                    { new Guid("75548054-31ea-432c-b12f-191f0c3a7924"), "Electrolux", 2011 },
                    { new Guid("1fa04ca1-36b4-4fc5-afaf-f712204e3808"), "Bosch", 2022 },
                    { new Guid("ff16208a-846a-4777-a1b1-906033ab2be7"), "LIBERTY", 2017 },
                    { new Guid("64850365-1246-4340-8d84-64af8ce8a84b"), "Smeg", 2021 },
                    { new Guid("4a013797-a6de-446a-9fca-9a2550f249d5"), "Snaige", 2018 },
                    { new Guid("b61ac0b1-727c-41a6-846e-db2a66338c8b"), "Samsung", 2019 },
                    { new Guid("b5fcaba7-1ce1-4cd6-b4bc-f3ca970eb46c"), "Gorenje", 2021 },
                    { new Guid("da5e110c-ab38-408a-ac8a-3968f453eba8"), "LG", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DefaultQuantity", "Name" },
                values: new object[,]
                {
                    { new Guid("f428d3b7-d5ae-4ada-8944-1d4a2e433238"), 10, "Ice" },
                    { new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), 2, "Milk" },
                    { new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"), 3, "Orange" },
                    { new Guid("3cd8e973-320d-410d-889a-8522767b6549"), 3, "Tomato" },
                    { new Guid("8186ec59-231a-4a94-a589-584e48ee567a"), 1, "Cola" },
                    { new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), 1, "Meat" },
                    { new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), 10, "Egg" },
                    { new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"), 1, "Fish" },
                    { new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"), 10, "Mushroom" }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "Id", "FridgeModelId", "Name", "OwnerName" },
                values: new object[,]
                {
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("919f36a2-0586-44e9-a67d-47d7bd519c79"), "Fridge4", "Owner4" },
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("b5fcaba7-1ce1-4cd6-b4bc-f3ca970eb46c"), "Fridge1", "Owner1" },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("b5fcaba7-1ce1-4cd6-b4bc-f3ca970eb46c"), "Fridge2", "Owner2" },
                    { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("b61ac0b1-727c-41a6-846e-db2a66338c8b"), "Fridge3", "Owner3" },
                    { new Guid("e15e5293-8204-4cdb-a79a-af8ca565b99e"), new Guid("da5e110c-ab38-408a-ac8a-3968f453eba8"), "Fridge5", "Owner5" },
                    { new Guid("1a749ddb-dde7-4141-8130-3eb5b517a6ab"), new Guid("da5e110c-ab38-408a-ac8a-3968f453eba8"), "Fridge6", "Owner6" },
                    { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("1fa04ca1-36b4-4fc5-afaf-f712204e3808"), "Fridge7", "Owner7" },
                    { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("64850365-1246-4340-8d84-64af8ce8a84b"), "Fridge8", "Owner8" },
                    { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("64850365-1246-4340-8d84-64af8ce8a84b"), "Fridge9", "Owner9" }
                });

            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "FridgeId", "ProductId", "Id", "Quantity" },
                values: new object[,]
                {
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"), new Guid("835b284c-f178-4e53-b5f5-5dd7bbbc446d"), 10 },
                    { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("86e1b250-c4f6-4e62-a0c3-034d8020df1e"), 1 },
                    { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a"), new Guid("d67c92b1-444a-4816-b376-1c10d6863874"), 1 },
                    { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("06e898eb-c594-4177-83ea-6bd71ca840c1"), 0 },
                    { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"), new Guid("9711181f-3bda-469d-86be-7ed393f44512"), 0 },
                    { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("d82d249d-3650-47c4-8fbb-808fbe2bee7f"), 10 },
                    { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"), new Guid("c49f01a9-87e3-471e-aec3-7baabfb70a77"), 1 },
                    { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("28363779-84e7-4e3f-9594-9b5ba036961c"), 1 },
                    { new Guid("1a749ddb-dde7-4141-8130-3eb5b517a6ab"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a"), new Guid("4b64f678-6c15-49c7-87bb-ce573e59e07c"), 3 },
                    { new Guid("1a749ddb-dde7-4141-8130-3eb5b517a6ab"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"), new Guid("2074bea9-3170-4f00-bfe3-e1a3e0ee62b2"), 1 },
                    { new Guid("e15e5293-8204-4cdb-a79a-af8ca565b99e"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"), new Guid("393d1430-bb04-4bdc-96f2-7378e8b3c8a0"), 6 },
                    { new Guid("e15e5293-8204-4cdb-a79a-af8ca565b99e"), new Guid("3cd8e973-320d-410d-889a-8522767b6549"), new Guid("ed0438a8-f6ed-4a90-a5c3-9cb79784df95"), 5 },
                    { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"), new Guid("35a3a4dd-7737-4694-98c1-9ff94067c02a"), 10 },
                    { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("b0fa869b-f73e-479e-b81c-1c71dcbca044"), 0 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("0cad8a9d-7f5e-40f9-8af1-88ad88b4703e"), 2 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("1c7906a9-26aa-48c7-9dd6-65c087ddbb1b"), 2 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("623b645c-a579-4ae1-9960-3b3a3dc00941"), 10 },
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("34b49f1a-6eca-4744-8d88-eaf1b3c38ec1"), 10 },
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("458f0692-8ad3-45ce-9733-483e14579f9b"), 1 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("f428d3b7-d5ae-4ada-8944-1d4a2e433238"), new Guid("e23cefa3-1649-4237-8ef0-335405324784"), 10 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"), new Guid("fc3ec0bf-1550-4ff0-94cc-28c810607e8f"), 1 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a"), new Guid("0c11c4d2-94c7-4a10-91f1-af6db6a6b28b"), 1 },
                    { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"), new Guid("cb9f59b5-751e-42a5-8cc2-8cd1259572e9"), 3 },
                    { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("3cd8e973-320d-410d-889a-8522767b6549"), new Guid("8953841e-2154-4bf8-a913-86983e6017d3"), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FridgeProducts_ProductId",
                table: "FridgeProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Fridges_FridgeModelId",
                table: "Fridges",
                column: "FridgeModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FridgeProducts");

            migrationBuilder.DropTable(
                name: "Fridges");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "FridgeModels");
        }
    }
}
