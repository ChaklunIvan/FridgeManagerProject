using InnowiseTask.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Test
{
    public static class TestConfiguration
    {
        //public TestConfiguration(List<FridgeProduct> fridgeProducts, List<Product> products, List<Fridge> fridges)
        //{
        //    FridgeProducts = fridgeProducts;
        //    Products = products;
        //    Fridges = fridges;
        //}


        public static List<Product> Products = new()
        {
            new Product
            {
                Id = new Guid("E5F23484-9191-4101-9CED-60C771B367BF"),
                Name = "Milk",
                DefaultQuantity = 2
            },
            new Product
            {
                Id = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"),
                Name = "Orange",
                DefaultQuantity = 3
            },
            new Product
            {
                Id = new Guid("3CD8E973-320D-410D-889A-8522767B6549"),
                Name = "Tomato",
                DefaultQuantity = 3
            },
            new Product
            {
                Id = new Guid("8186EC59-231A-4A94-A589-584E48EE567A"),
                Name = "Cola",
                DefaultQuantity = 1
            },
            new Product
            {
                Id = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),
                Name = "Meat",
                DefaultQuantity = 1
            },
            new Product
            {
                Id = new Guid("0CA04EA8-EA69-457D-B564-9070492BD444"),
                Name = "Egg",
                DefaultQuantity = 10
            },
            new Product
            {
                Id = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),
                Name = "Fish",
                DefaultQuantity = 1
            },
            new Product
            {
                Id = new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238"),
                Name = "Ice",
                DefaultQuantity = 10
            },
            new Product
            {
                Id = new Guid("B7C5EF3A-4132-4D10-8A9D-782EBC524AF9"),
                Name = "Mushroom",
                DefaultQuantity = 10
            }
        };

        public static List<Fridge> Fridges = new()
        {
            new Fridge
            {
                Id = new Guid("2CEB4D63-4DEF-4296-978D-91D74AB59208"),
                Name = "Fridge1",
                OwnerName = "Owner1",
                FridgeModelId = new Guid("B5FCABA7-1CE1-4CD6-B4BC-F3CA970EB46C"),
            },
            new Fridge
            {
                Id = new Guid("1F05DE3D-A6A7-4479-A662-B2F365D656CE"),
                Name = "Fridge2",
                OwnerName = "Owner2",
                FridgeModelId = new Guid("B5FCABA7-1CE1-4CD6-B4BC-F3CA970EB46C"),
            },
            new Fridge
            {
                Id = new Guid("A75C18D9-A2B6-42CD-94D7-CC73F5AFBF44"),
                Name = "Fridge3",
                OwnerName = "Owner3",
                FridgeModelId = new Guid("B61AC0B1-727C-41A6-846E-DB2A66338C8B"),
            },
            new Fridge
            {
                Id = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                Name = "Fridge4",
                OwnerName = "Owner4",
                FridgeModelId = new Guid("919F36A2-0586-44E9-A67D-47D7BD519C79"),
            },
            new Fridge
            {
                Id = new Guid("E15E5293-8204-4CDB-A79A-AF8CA565B99E"),
                Name = "Fridge5",
                OwnerName = "Owner5",
                FridgeModelId = new Guid("DA5E110C-AB38-408A-AC8A-3968F453EBA8"),
            },
            new Fridge
            {
                Id = new Guid("1A749DDB-DDE7-4141-8130-3EB5B517A6AB"),
                Name = "Fridge6",
                OwnerName = "Owner6",
                FridgeModelId = new Guid("DA5E110C-AB38-408A-AC8A-3968F453EBA8"),
            },
            new Fridge
            {
                Id = new Guid("CF4AE0BA-B055-4F64-BC41-9811EAAA7280"),
                Name = "Fridge7",
                OwnerName = "Owner7",
                FridgeModelId = new Guid("1FA04CA1-36B4-4FC5-AFAF-F712204E3808"),
            },
            new Fridge
            {
                Id = new Guid("86563649-951A-4A02-BE1B-8F07EF0A3EDE"),
                Name = "Fridge8",
                OwnerName = "Owner8",
                FridgeModelId = new Guid("64850365-1246-4340-8D84-64AF8CE8A84B"),
            },
            new Fridge
            {
                Id = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"),
                Name = "Fridge9",
                OwnerName = "Owner9",
                FridgeModelId = new Guid("64850365-1246-4340-8D84-64AF8CE8A84B"),
            }
        };

        public static List<FridgeProduct> FridgeProducts = new()
        {
            new FridgeProduct
            {
                FridgeId = new Guid("A75C18D9-A2B6-42CD-94D7-CC73F5AFBF44"),
                ProductId = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),
                Quantity = 4
            },
            new FridgeProduct
            {
                FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                Fridge = Fridges[3],
                ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),
                Product = Products[4],
                Quantity = 1
            },
            new FridgeProduct
            {
                FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                Fridge = Fridges[3],
                ProductId = new Guid("E5F23484-9191-4101-9CED-60C771B367BF"),
                Product = Products[0],
                Quantity = 2
            },
            new FridgeProduct
            {
                FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"),
                Fridge = Fridges[3],
                ProductId = new Guid("3CD8E973-320D-410D-889A-8522767B6549"),
                Product = Products[2],
                Quantity = 3
            }
        };

    }
}