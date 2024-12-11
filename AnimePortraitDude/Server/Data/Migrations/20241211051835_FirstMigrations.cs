using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "04e6c5cd-a5e7-4ec5-9be9-f8de3a7ef030", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, "Product 8" },
                    { "0e12a861-27b4-4c0e-9c44-978f88f504e5", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, "Product 7" },
                    { "3db0be45-0dc3-4970-9d37-750f5eb2ab67", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, "Product 1" },
                    { "3f3771b7-dd25-45f2-ac75-f535608a2d9e", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, "Product 13" },
                    { "4500234c-6959-452e-a5d6-5efa56a88fd1", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, "Product 6" },
                    { "5a09a5e2-f960-49a8-9a43-a373bbb09552", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, "Product 14" },
                    { "6d713ccf-fc11-4745-a564-fdff6442c265", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, "Product 9" },
                    { "735855a8-9a4a-41b6-a905-8b6990f440c1", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, "Product 17" },
                    { "7d4a1249-94a9-42ef-a77d-6e33b8b756bc", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, "Product 10" },
                    { "7e545db0-b56a-455d-83b9-e212652317a5", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, "Product 5" },
                    { "9a1671c0-acb1-434b-bfea-5bd7a2d4400a", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, "Product 3" },
                    { "9d3fed1b-344c-4134-b766-77f09a048461", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, "Product 16" },
                    { "a44a9dc7-5635-442a-8484-e5649becfe56", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, "Product 15" },
                    { "b528c6b4-2f6c-478b-a78a-8470ee60e1f1", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, "Product 20" },
                    { "b8c170d0-cc62-43e9-a9fd-d8776dd1e31b", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, "Product 19" },
                    { "c0274db5-0cd4-4200-beaf-ed7bd1d0e928", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, "Product 12" },
                    { "da1fa417-11bb-4b54-90ac-221d5f3dcc1f", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, "Product 4" },
                    { "db8914a6-3442-40c0-b6d6-2c351be4355f", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, "Product 18" },
                    { "ddda1c73-0d01-4c29-b503-d0833c58c797", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, "Product 11" },
                    { "f01ce0d1-21eb-413f-8770-c8f00b208b2f", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, "Product 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
