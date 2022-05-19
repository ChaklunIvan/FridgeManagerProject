//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;

//namespace InnowiseTask.Server.Data.Models.Configurations
//{
//    public class FridgeProductConfiguration : IEntityTypeConfiguration<FridgeProduct>
//    {
//        public void Configure(EntityTypeBuilder<FridgeProduct> builder)
//        {
//            builder.HasData
//                (
//                new FridgeProduct
//                {
//                    Id = new Guid("458F0692-8AD3-45CE-9733-483E14579F9B"),
//                    FridgeId = new Guid("2CEB4D63-4DEF-4296-978D-91D74AB59208"),
//                    ProductId = new Guid("E5F23484-9191-4101-9CED-60C771B367BF"),//Milk
//                    Quantity = 1,
//                },
//                new FridgeProduct
//                {
//                    Id = new Guid("34B49F1A-6ECA-4744-8D88-EAF1B3C38EC1"),
//                    FridgeId = new Guid("2CEB4D63-4DEF-4296-978D-91D74AB59208"),
//                    ProductId = new Guid("0CA04EA8-EA69-457D-B564-9070492BD444"),//Egg
//                    Quantity = 10,
//                },
//                new FridgeProduct
//                {
//                    Id = new Guid("623B645C-A579-4AE1-9960-3B3A3DC00941"),
//                    FridgeId = new Guid("1F05DE3D-A6A7-4479-A662-B2F365D656CE"),
//                    ProductId = new Guid("0CA04EA8-EA69-457D-B564-9070492BD444"),//Egg
//                    Quantity = 10,
//                    Fridge = new Fridge
//                    {
//                        Id = new Guid("1F05DE3D-A6A7-4479-A662-B2F365D656CE")
//                    }
//                },
//                new FridgeProduct
//                {
//                    Id = new Guid("1C7906A9-26AA-48C7-9DD6-65C087DDBB1B"),
//                    FridgeId = new Guid("1F05DE3D-A6A7-4479-A662-B2F365D656CE"),
//                    ProductId = new Guid("E5F23484-9191-4101-9CED-60C771B367BF"),//Milk
//                    Quantity = 2,
//                }
                //new FridgeProduct
                //{
                //    Id = new Guid("0CAD8A9D-7F5E-40F9-8AF1-88AD88B4703E"),
                //    FridgeId = new Guid("1F05DE3D-A6A7-4479-A662-B2F365D656CE"),
                //    ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),//Meat
                //    Quantity = 2
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("B0FA869B-F73E-479E-B81C-1C71DCBCA044"),
                //    FridgeId = new Guid("A75C18D9-A2B6-42CD-94D7-CC73F5AFBF44"),
                //    ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),//Meat
                //    Quantity = 0
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("35A3A4DD-7737-4694-98C1-9FF94067C02A"),
                //    FridgeId = new Guid("A75C18D9-A2B6-42CD-94D7-CC73F5AFBF44"),
                //    ProductId = new Guid("B7C5EF3A-4132-4D10-8A9D-782EBC524AF9"),//Mushroom
                //    Quantity = 10
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("835B284C-F178-4E53-B5F5-5DD7BBBC446D"),
                //    FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                //    ProductId = new Guid("B7C5EF3A-4132-4D10-8A9D-782EBC524AF9"),//Mushroom
                //    Quantity = 10
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("0C11C4D2-94C7-4A10-91F1-AF6DB6A6B28B"),
                //    FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                //    ProductId = new Guid("8186EC59-231A-4A94-A589-584E48EE567A"),//Cola
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("FC3EC0BF-1550-4FF0-94CC-28C810607E8F"),
                //    FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                //    ProductId = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),//Fish
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("E23CEFA3-1649-4237-8EF0-335405324784"),
                //    FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                //    ProductId = new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238"),//Ice
                //    Quantity = 10
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("ED0438A8-F6ED-4A90-A5C3-9CB79784DF95"),
                //    FridgeId = new Guid("E15E5293-8204-4CDB-A79A-AF8CA565B99E"),
                //    ProductId = new Guid("3CD8E973-320D-410D-889A-8522767B6549"),//Tomato
                //    Quantity = 5
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("393D1430-BB04-4BDC-96F2-7378E8B3C8A0"),
                //    FridgeId = new Guid("E15E5293-8204-4CDB-A79A-AF8CA565B99E"),
                //    ProductId = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"),//Orange
                //    Quantity = 6
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("2074BEA9-3170-4F00-BFE3-E1A3E0EE62B2"),
                //    FridgeId = new Guid("1A749DDB-DDE7-4141-8130-3EB5B517A6AB"),
                //    ProductId = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"),//Orange
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("4B64F678-6C15-49C7-87BB-CE573E59E07C"),
                //    FridgeId = new Guid("1A749DDB-DDE7-4141-8130-3EB5B517A6AB"),
                //    ProductId = new Guid("8186EC59-231A-4A94-A589-584E48EE567A"),//Cola
                //    Quantity = 3
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("28363779-84E7-4E3F-9594-9B5BA036961C"),
                //    FridgeId = new Guid("CF4AE0BA-B055-4F64-BC41-9811EAAA7280"),
                //    ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),//Meat
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("C49F01A9-87E3-471E-AEC3-7BAABFB70A77"),
                //    FridgeId = new Guid("CF4AE0BA-B055-4F64-BC41-9811EAAA7280"),
                //    ProductId = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),//Fish
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("D82D249D-3650-47C4-8FBB-808FBE2BEE7F"),
                //    FridgeId = new Guid("CF4AE0BA-B055-4F64-BC41-9811EAAA7280"),
                //    ProductId = new Guid("0CA04EA8-EA69-457D-B564-9070492BD444"),//Egg
                //    Quantity = 10
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("9711181F-3BDA-469D-86BE-7ED393F44512"),
                //    FridgeId = new Guid("86563649-951A-4A02-BE1B-8F07EF0A3EDE"),
                //    ProductId = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),//fish
                //    Quantity = 0
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("06E898EB-C594-4177-83EA-6BD71CA840C1"),
                //    FridgeId = new Guid("86563649-951A-4A02-BE1B-8F07EF0A3EDE"),
                //    ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),//meat
                //    Quantity = 0
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("D67C92B1-444A-4816-B376-1C10D6863874"),
                //    FridgeId = new Guid("86563649-951A-4A02-BE1B-8F07EF0A3EDE"),
                //    ProductId = new Guid("8186EC59-231A-4A94-A589-584E48EE567A"),//Cola
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("86E1B250-C4F6-4E62-A0C3-034D8020DF1E"),
                //    FridgeId = new Guid("86563649-951A-4A02-BE1B-8F07EF0A3EDE"),
                //    ProductId = new Guid("E5F23484-9191-4101-9CED-60C771B367BF"),//Milk
                //    Quantity = 1
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("CB9F59B5-751E-42A5-8CC2-8CD1259572E9"),
                //    FridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"),
                //    ProductId = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"),//Orange
                //    Quantity = 3
                //},
                //new FridgeProduct
                //{
                //    Id = new Guid("8953841E-2154-4BF8-A913-86983E6017D3"),
                //    FridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"),
                //    ProductId = new Guid("3CD8E973-320D-410D-889A-8522767B6549"),//Milk
                //    Quantity = 3
                //}
//                );
//        }
//    }
//}

