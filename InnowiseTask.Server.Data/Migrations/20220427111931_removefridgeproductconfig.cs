using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class removefridgeproductconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1a749ddb-dde7-4141-8130-3eb5b517a6ab"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1a749ddb-dde7-4141-8130-3eb5b517a6ab"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b") });

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

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("f428d3b7-d5ae-4ada-8944-1d4a2e433238") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("3cd8e973-320d-410d-889a-8522767b6549") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("86563649-951a-4a02-be1b-8f07ef0a3ede"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("cf4ae0ba-b055-4f64-bc41-9811eaaa7280"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("e15e5293-8204-4cdb-a79a-af8ca565b99e"), new Guid("3cd8e973-320d-410d-889a-8522767b6549") });

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumns: new[] { "FridgeId", "ProductId" },
                keyValues: new object[] { new Guid("e15e5293-8204-4cdb-a79a-af8ca565b99e"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "FridgeId", "ProductId", "Id", "Quantity" },
                values: new object[,]
                {
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("458f0692-8ad3-45ce-9733-483e14579f9b"), 1 },
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
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("f428d3b7-d5ae-4ada-8944-1d4a2e433238"), new Guid("e23cefa3-1649-4237-8ef0-335405324784"), 10 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"), new Guid("fc3ec0bf-1550-4ff0-94cc-28c810607e8f"), 1 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("8186ec59-231a-4a94-a589-584e48ee567a"), new Guid("0c11c4d2-94c7-4a10-91f1-af6db6a6b28b"), 1 },
                    { new Guid("356c09b5-d03b-4d86-aaba-c59e6937c0cf"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"), new Guid("835b284c-f178-4e53-b5f5-5dd7bbbc446d"), 10 },
                    { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"), new Guid("35a3a4dd-7737-4694-98c1-9ff94067c02a"), 10 },
                    { new Guid("a75c18d9-a2b6-42cd-94d7-cc73f5afbf44"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("b0fa869b-f73e-479e-b81c-1c71dcbca044"), 0 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"), new Guid("0cad8a9d-7f5e-40f9-8af1-88ad88b4703e"), 2 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("e5f23484-9191-4101-9ced-60c771b367bf"), new Guid("1c7906a9-26aa-48c7-9dd6-65c087ddbb1b"), 2 },
                    { new Guid("1f05de3d-a6a7-4479-a662-b2f365d656ce"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("623b645c-a579-4ae1-9960-3b3a3dc00941"), 10 },
                    { new Guid("2ceb4d63-4def-4296-978d-91d74ab59208"), new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"), new Guid("34b49f1a-6eca-4744-8d88-eaf1b3c38ec1"), 10 },
                    { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"), new Guid("cb9f59b5-751e-42a5-8cc2-8cd1259572e9"), 3 },
                    { new Guid("4c086779-212e-4864-be35-6749f4ee47cd"), new Guid("3cd8e973-320d-410d-889a-8522767b6549"), new Guid("8953841e-2154-4bf8-a913-86983e6017d3"), 3 }
                });
        }
    }
}
