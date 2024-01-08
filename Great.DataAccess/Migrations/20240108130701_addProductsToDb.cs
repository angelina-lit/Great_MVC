using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreatFilms.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Price", "Price100", "Price50", "Producer", "SKU", "Title" },
                values: new object[,]
                {
                    { 1, "Hardin (Hero Fiennes Tiffin) is struggling to move forward. Besieged by writer’s block and the crushing breakup with Tessa (Josephine Landford), Hardin travels to Portugal in search of a woman he wronged in the past – and to find himself. Hoping to win back Tessa, he realises he needs to change his ways before he can make the ultimate commitment. ", 99.0, 90.0, 80.0, 85.0, "Hero Fiennes-Tiffin", "5G3S9R11101", "After Everything" },
                    { 2, "OPTIMUS PRIME and the AUTOBOTS take on their biggest challenge yet in this adrenaline-fueled adbentire with pulse-pounding action. When a new threat capable of destroying the entire planet emerges, they must team up with a powerful faction known as the MAXIMALS. With the fate of humanity hanging in the balance Noah (Anthony Ramos) and Elena (Dominique Fishback) will do whatever it takes to help the TRANSFORMERS allies as they engage in the ultimatebattle to save Earth in this exciting new chapter in the TRANSFORMERS saga. ", 40.0, 30.0, 20.0, 25.0, "Steven Caple Jr.", "5G3S9R11111", "Transformers: Rise of the Beasts" },
                    { 3, "Inspired by the 1985 true story of a drug runner's plane crash, missing cocaine, and the black bear that ate it, this wild dark comedy finds an oddball group of cops, criminals, tourists and teens converging in a Georgia forest where a 500- pound apex predator has ingested a staggering amount of cocaine and gone on a coke-fueled rampage for more blow … and blood. ", 55.0, 50.0, 35.0, 40.0, "Elizabeth Banks", "5G3S9R33333", "Cocaine Bear" },
                    { 4, "After a catastrophic crash on an unknown planet, pilot Mills (Adam Driver) quickly discovers he's actually stranded on Earth... 65 million years ago. Now, with only one chance at rescue, Mills and the only other survivor, Koa (Ariana Greenblatt), must make their way across an unknown terrain riddled with dangerous prehistoric creatures in an epic fight to survive. From the writers of A Quiet Place and producer Sam Raimi comes 65, a sci-fi thriller starring Adam Driver, Ariana Greenblatt, and Chloe Coleman. ", 70.0, 65.0, 55.0, 60.0, "Scott Beck", "5G3S9R44444", "65 (2023)" },
                    { 5, "Maddie thinks she's found the answer to her financial troubles when she discovers an intriguing job listing: wealthy helicopter parents looking for someone to \"date\" their introverted 19-year-old son, Percy, and bring him out of his shell before he leaves for college. But awkward Percy proves to be a real challenge, and time is running out. She has one summer to make him a man or lose it all. ", 30.0, 27.0, 20.0, 25.0, "Alex Saks", "5G3S9R55555", "No Hard Feelings" },
                    { 6, "An ordinary young boy called Nikolas sets out on an extraordinary adventure into the snowy north in search of his father who is on a quest to discover the fabled village of the elves, Elfhelm. Taking with him a headstrong reindeer called Blitzen and a loyal pet mouse, Nikolas soon meets his destiny in this magical, comic and endearing story that proves nothing is impossible. ", 25.0, 23.0, 20.0, 22.0, "Gil Kenan", "5G3S966666", "Boy Called Christmas, A" }
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
