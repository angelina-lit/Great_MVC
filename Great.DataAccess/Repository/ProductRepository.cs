using GreatFilms.DataAccess.Data;
using GreatFilms.DataAccess.Repository.IRepository;
using GreatFilms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreatFilms.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
		private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(Product obj)
		{
			var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);

			if (objFromDb != null)
			{
				objFromDb.Title = obj.Title;
				objFromDb.Description = obj.Description;
				objFromDb.CategoryId = obj.CategoryId;
				objFromDb.SKU = obj.SKU;
				objFromDb.Producer = obj.Producer;
				objFromDb.PreviousPrice = obj.PreviousPrice;
				objFromDb.Price = obj.Price;
				objFromDb.Price4 = obj.Price4;
				objFromDb.Price9 = obj.Price9;
				objFromDb.ProductImages = obj.ProductImages;

				//if (obj.ImageUrl != null)
				//{
				//	objFromDb.ImageUrl = obj.ImageUrl;
				//}
			}
		}
	}
}
