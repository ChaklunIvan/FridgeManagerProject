using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace InnowiseTask.Server.Data.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
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
                );
        }
    }
}
