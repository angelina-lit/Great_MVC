using GreatFilms.Models;
using Microsoft.EntityFrameworkCore;

namespace GreatFilms.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
				);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "After Everything",
                    Producer = "Hero Fiennes-Tiffin",
                    Description = "Hardin (Hero Fiennes Tiffin) is struggling to move forward. Besieged by writer’s block and the crushing breakup " +
                    "with Tessa (Josephine Landford), Hardin travels to Portugal in search of a woman he wronged in the past – and to find himself. " +
                    "Hoping to win back Tessa, he realises he needs to change his ways before he can make the ultimate commitment. ",
                    SKU = "5G3S9R11101",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Transformers: Rise of the Beasts",
                    Producer = "Steven Caple Jr.",
                    Description = "OPTIMUS PRIME and the AUTOBOTS take on their biggest challenge yet in this adrenaline-fueled adbentire with " +
                    "pulse-pounding action. When a new threat capable of destroying the entire planet emerges, they must team up with a powerful " +
                    "faction known as the MAXIMALS. With the fate of humanity hanging in the balance Noah (Anthony Ramos) and Elena (Dominique Fishback) " +
                    "will do whatever it takes to help the TRANSFORMERS allies as they engage in the ultimatebattle to save Earth in this exciting new chapter in the TRANSFORMERS saga. ",
                    SKU = "5G3S9R11111",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
					ImageUrl = ""
				},
                new Product
                {
                    Id = 3,
                    Title = "Cocaine Bear",
                    Producer = "Elizabeth Banks",
                    Description = "Inspired by the 1985 true story of a drug runner's plane crash, missing cocaine, and the black bear that ate it, " +
                    "this wild dark comedy finds an oddball group of cops, criminals, tourists and teens converging in a Georgia forest where a 500- " +
                    "pound apex predator has ingested a staggering amount of cocaine and gone on a coke-fueled rampage for more blow … and blood. ",
                    SKU = "5G3S9R33333",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
					ImageUrl = ""
				},
                new Product
                {
                    Id = 4,
                    Title = "65 (2023)",
                    Producer = "Scott Beck",
                    Description = "After a catastrophic crash on an unknown planet, pilot Mills (Adam Driver) quickly discovers he's actually stranded on " +
                    "Earth... 65 million years ago. Now, with only one chance at rescue, Mills and the only other survivor, Koa (Ariana Greenblatt), must " +
                    "make their way across an unknown terrain riddled with dangerous prehistoric creatures in an epic fight to survive. From the writers of " +
                    "A Quiet Place and producer Sam Raimi comes 65, a sci-fi thriller starring Adam Driver, Ariana Greenblatt, and Chloe Coleman. ",
                    SKU = "5G3S9R44444",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 1,
					ImageUrl = ""
				},
                new Product
                {
                    Id = 5,
                    Title = "No Hard Feelings",
                    Producer = "Alex Saks",
                    Description = "Maddie thinks she's found the answer to her financial troubles when she discovers an intriguing job listing: wealthy " +
                    "helicopter parents looking for someone to \"date\" their introverted 19-year-old son, Percy, and bring him out of his shell before " +
                    "he leaves for college. But awkward Percy proves to be a real challenge, and time is running out. She has one summer to make him a man or lose it all. ",
                    SKU = "5G3S9R55555",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
					ImageUrl = ""
				},
                new Product
                {
                    Id = 6,
                    Title = "Boy Called Christmas, A",
                    Producer = "Gil Kenan",
                    Description = "An ordinary young boy called Nikolas sets out on an extraordinary adventure into the snowy north in search of his " +
                    "father who is on a quest to discover the fabled village of the elves, Elfhelm. Taking with him a headstrong reindeer called Blitzen " +
                    "and a loyal pet mouse, Nikolas soon meets his destiny in this magical, comic and endearing story that proves nothing is impossible. ",
                    SKU = "5G3S9R66666",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 2,
					ImageUrl = ""
				}
                );
        }
    }
}
