using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreatFilms.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNamePrice50AndPrice100ToPrice4AndPrice9Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price50",
                table: "Products",
                newName: "Price9");

            migrationBuilder.RenameColumn(
                name: "Price100",
                table: "Products",
                newName: "Price4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 85.0, 80.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 25.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 40.0, 35.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 60.0, 55.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 25.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price4", "Price9" },
                values: new object[] { 22.0, 20.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price9",
                table: "Products",
                newName: "Price50");

            migrationBuilder.RenameColumn(
                name: "Price4",
                table: "Products",
                newName: "Price100");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 80.0, 85.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 20.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 35.0, 40.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 55.0, 60.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 20.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price100", "Price50" },
                values: new object[] { 20.0, 22.0 });
        }
    }
}
