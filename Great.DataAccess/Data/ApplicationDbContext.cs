using GreatFilms.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GreatFilms.DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ApplicationUser> applicationUser { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
				new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
				new Category { Id = 3, Name = "History", DisplayOrder = 3 }
				);

			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = 1,
					Name = "Tech Solution",
					StreetAddress = "123 Tech st",
					City = "Tech City",
					PostalCode = "12121",
					State = "IL",
					PhoneNumber = "77777777777"
				},
				new Company
				{
					Id = 2,
					Name = "HR Solution",
					StreetAddress = "123 HR st",
					City = "HR City",
					PostalCode = "12122",
					State = "RI",
					PhoneNumber = "77777777778"
				},
				new Company
				{
					Id = 3,
					Name = "Break Solution",
					StreetAddress = "123 Break st",
					City = "Break City",
					PostalCode = "12123",
					State = "NY",
					PhoneNumber = "77777777779"
				}
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
                    PreviousPrice = 99,
					Price = 90,
					Price4 = 85,
					Price9 = 80,
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
                    PreviousPrice = 40,
					Price = 30,
					Price4 = 25,
					Price9 = 20,
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
                    PreviousPrice = 55,
					Price = 50,
					Price4 = 40,
					Price9 = 35,
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
                    PreviousPrice = 70,
					Price = 65,
					Price4 = 60,
					Price9 = 55,
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
                    PreviousPrice = 30,
					Price = 27,
					Price4 = 25,
					Price9 = 20,
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
                    PreviousPrice = 25,
					Price = 23,
					Price4 = 22,
					Price9 = 20,
					CategoryId = 2,
					ImageUrl = ""
				}
				);
		}
	}
}
