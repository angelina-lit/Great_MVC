using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreatFilms.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameListPriceToPreviousPriceProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ListPrice",
                table: "Products",
                newName: "PreviousPrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreviousPrice",
                table: "Products",
                newName: "ListPrice");
        }
    }
}
