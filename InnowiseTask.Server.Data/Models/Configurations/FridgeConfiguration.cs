using InnowiseTask.Server.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InnowiseTask.Server.Data.Models.Configurations
{
    public class FridgeConfiguration : IEntityTypeConfiguration<Fridge>
    {
        public void Configure(EntityTypeBuilder<Fridge> builder)
        {
            builder.HasData
                (
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
                );
        }
    }
}
