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
                    DefaultQuantity = 2,
                    Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/Glass-and-bottle-of-milk-fe0997a.jpg?quality=90&resize=960,872"
                },
                new Product
                {
                    Id = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"),
                    Name = "Orange",
                    DefaultQuantity = 3,
                    Image = "https://media.istockphoto.com/photos/orange-picture-id185284489?k=20&m=185284489&s=612x612&w=0&h=LLY2os0YTG2uAzpBKpQZOAC4DGiXBt1jJrltErTJTKI="
                },
                new Product
                {
                    Id = new Guid("3CD8E973-320D-410D-889A-8522767B6549"),
                    Name = "Tomato",
                    DefaultQuantity = 3,
                    Image = "https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg"
                },
                new Product
                {
                    Id = new Guid("8186EC59-231A-4A94-A589-584E48EE567A"),
                    Name = "Cola",
                    DefaultQuantity = 1,
                    Image = "https://media.istockphoto.com/photos/coke-picture-id458464735"
                },
                new Product
                {
                    Id = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"),
                    Name = "Meat",
                    DefaultQuantity = 1,
                    Image = "https://media.istockphoto.com/photos/assortment-of-meat-and-seafood-picture-id1212824120?k=20&m=1212824120&s=612x612&w=0&h=yHkNBM-cUaMXEdVQj1GzZ_AAZ9tsV06dMuYIzcRzqbM="
                },
                new Product
                {
                    Id = new Guid("0CA04EA8-EA69-457D-B564-9070492BD444"),
                    Name = "Egg",
                    DefaultQuantity = 10,
                    Image = "https://cdn.britannica.com/94/151894-050-F72A5317/Brown-eggs.jpg"
                },
                new Product
                {
                    Id = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4"),
                    Name = "Fish",
                    DefaultQuantity = 1,
                    Image = "https://ychef.files.bbci.co.uk/976x549/p091595d.jpg"
                },
                new Product
                {
                    Id = new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238"),
                    Name = "Ice",
                    DefaultQuantity = 10,
                    Image = "https://media.istockphoto.com/photos/ice-cubes-picture-id177131518?k=20&m=177131518&s=612x612&w=0&h=Bym7fbnY-eOI0CvFJhPJv_B4uLhTjul4ThN05p_Eao0="
                },
                new Product
                {
                    Id = new Guid("B7C5EF3A-4132-4D10-8A9D-782EBC524AF9"),
                    Name = "Mushroom",
                    DefaultQuantity = 10,
                    Image = "https://cdn-prod.medicalnewstoday.com/content/images/articles/278/278858/mushrooms-in-a-bowel-on-a-dark-table.jpg"
                }
                );
        }
    }
}
