using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace InnowiseTask.Server.Data.Models.Configurations
{
    public class FridgeModelConfiguration : IEntityTypeConfiguration<FridgeModel>
    {
        public void Configure(EntityTypeBuilder<FridgeModel> builder)
        {
            builder.HasData
                (
                new FridgeModel
                {
                    Id = new Guid("919F36A2-0586-44E9-A67D-47D7BD519C79"),
                    Name = "Liebherr",
                    Year = 2020
                },
                new FridgeModel
                {
                    Id = new Guid("B5FCABA7-1CE1-4CD6-B4BC-F3CA970EB46C"),
                    Name = "Gorenje",
                    Year = 2021
                },
                new FridgeModel
                {
                    Id = new Guid("B61AC0B1-727C-41A6-846E-DB2A66338C8B"),
                    Name = "Samsung",
                    Year = 2019
                },
                new FridgeModel
                {
                    Id = new Guid("4A013797-A6DE-446A-9FCA-9A2550F249D5"),
                    Name = "Snaige",
                    Year = 2018
                },
                new FridgeModel
                {
                    Id = new Guid("DA5E110C-AB38-408A-AC8A-3968F453EBA8"),
                    Name = "LG",
                    Year = 2019
                },
                new FridgeModel
                {
                    Id = new Guid("FF16208A-846A-4777-A1B1-906033AB2BE7"),
                    Name = "LIBERTY",
                    Year = 2017
                },
                new FridgeModel
                {
                    Id = new Guid("1FA04CA1-36B4-4FC5-AFAF-F712204E3808"),
                    Name = "Bosch",
                    Year = 2022
                },
                new FridgeModel
                {
                    Id = new Guid("75548054-31EA-432C-B12F-191F0C3A7924"),
                    Name = "Electrolux",
                    Year = 2011
                },
                new FridgeModel
                {
                    Id = new Guid("64850365-1246-4340-8D84-64AF8CE8A84B"),
                    Name = "Smeg",
                    Year = 2021
                }
                );
        }
    }
}
