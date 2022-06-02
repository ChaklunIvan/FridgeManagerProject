using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InnowiseTask.Server.Data.Migrations
{
    public partial class Add_User_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ca04ea8-ea69-457d-b564-9070492bd444"),
                column: "Image",
                value: "https://cdn.britannica.com/94/151894-050-F72A5317/Brown-eggs.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d601bc-965f-457f-ae2e-5bf34afcba8b"),
                column: "Image",
                value: "https://media.istockphoto.com/photos/assortment-of-meat-and-seafood-picture-id1212824120?k=20&m=1212824120&s=612x612&w=0&h=yHkNBM-cUaMXEdVQj1GzZ_AAZ9tsV06dMuYIzcRzqbM=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2888dc78-ae37-4a63-a09a-b3b356b47dd4"),
                column: "Image",
                value: "https://ychef.files.bbci.co.uk/976x549/p091595d.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cd8e973-320d-410d-889a-8522767b6549"),
                column: "Image",
                value: "https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8186ec59-231a-4a94-a589-584e48ee567a"),
                column: "Image",
                value: "https://media.istockphoto.com/photos/coke-picture-id458464735");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f4dda36-4be7-4ebb-9a09-51448de3ec92"),
                column: "Image",
                value: "https://media.istockphoto.com/photos/orange-picture-id185284489?k=20&m=185284489&s=612x612&w=0&h=LLY2os0YTG2uAzpBKpQZOAC4DGiXBt1jJrltErTJTKI=");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7c5ef3a-4132-4d10-8a9d-782ebc524af9"),
                column: "Image",
                value: "https://cdn-prod.medicalnewstoday.com/content/images/articles/278/278858/mushrooms-in-a-bowel-on-a-dark-table.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5f23484-9191-4101-9ced-60c771b367bf"),
                column: "Image",
                value: "https://images.immediate.co.uk/production/volatile/sites/30/2020/02/Glass-and-bottle-of-milk-fe0997a.jpg?quality=90&resize=960,872");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f428d3b7-d5ae-4ada-8944-1d4a2e433238"),
                column: "Image",
                value: "https://media.istockphoto.com/photos/ice-cubes-picture-id177131518?k=20&m=177131518&s=612x612&w=0&h=Bym7fbnY-eOI0CvFJhPJv_B4uLhTjul4ThN05p_Eao0=");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { new Guid("d8c2f458-16f7-41fd-8f2f-dd8e717d0997"), "admin@gmail.com", "Admin", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");
        }
    }
}
