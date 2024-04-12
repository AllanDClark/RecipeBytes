using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipeBytes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class moreseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsSoftDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("082e3d35-95b2-409a-9ba9-c8c9b15a877b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Noodles and pork", "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964559/whk9yu5xsbr7cvszwtte.jpg", false, "Ramen noodles", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("739defb6-3d8a-432e-a4e7-0171e22a3a0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Marg-her-ehhh-tay", "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964879/bwglvzxvy9uzdwwglhzb.jpg", false, "Homemade Margherita Pizza", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("96a6f4e5-e108-4b8f-8c47-1a2c98d6019e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "What I said was, 'give me all the bacon and eggs you have.'", "https://res.cloudinary.com/daspbl6sb/image/upload/v1712964467/james-kern-aLDW0oQ0NtU-unsplash_ypclxp.jpg", false, "Bacon and Eggs", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a2c3c1e1-f0ed-4d4d-a698-9f7ee2177d8b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "It is not a lie.", "https://res.cloudinary.com/daspbl6sb/image/upload/v1712965428/hjc02v2ngl00lc0zgxtx.jpg", false, "Chocolate Cake", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b8a3efb4-50bd-41b5-832e-3d59d783b4a9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Why did the taco go to the party? Because it wanted to taco 'bout it later!", "https://res.cloudinary.com/daspbl6sb/image/upload/v1712965310/o2qgx0yifaty6ikcpmf1.jpg", false, "Carnitas Tacos", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("082e3d35-95b2-409a-9ba9-c8c9b15a877b"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("739defb6-3d8a-432e-a4e7-0171e22a3a0f"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("96a6f4e5-e108-4b8f-8c47-1a2c98d6019e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("a2c3c1e1-f0ed-4d4d-a698-9f7ee2177d8b"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b8a3efb4-50bd-41b5-832e-3d59d783b4a9"));
        }
    }
}
