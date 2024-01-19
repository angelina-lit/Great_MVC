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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
	{
		private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(OrderHeader obj)
		{
			_db.OrderHeaders.Update(obj);
		}
	}
}
