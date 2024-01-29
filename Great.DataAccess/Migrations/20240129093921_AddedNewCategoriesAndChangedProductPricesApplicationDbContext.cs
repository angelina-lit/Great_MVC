using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreatFilms.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewCategoriesAndChangedProductPricesApplicationDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Comedy");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, 4, "Drama" },
                    { 5, 5, "Horror" },
                    { 6, 6, "Adventure" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PreviousPrice" },
                values: new object[] { 4, 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 1, 110.0, 100.0, 95.0, 90.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 5, 70.0, 60.0, 55.0, 50.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 2, 80.0, 70.0, 65.0, 60.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 3, 75.0, 65.0, 60.0, 55.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9", "Title" },
                values: new object[] { 6, 85.0, 75.0, 70.0, 65.0, "A Boy Called Christmas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "PreviousPrice" },
                values: new object[] { 1, 99.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 2, 40.0, 30.0, 25.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 3, 55.0, 50.0, 40.0, 35.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 1, 70.0, 65.0, 60.0, 55.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9" },
                values: new object[] { 2, 30.0, 27.0, 25.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PreviousPrice", "Price", "Price4", "Price9", "Title" },
                values: new object[] { 2, 25.0, 23.0, 22.0, 20.0, "Boy Called Christmas, A" });
        }
    }
}
