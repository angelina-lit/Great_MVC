﻿using GreatWeb.Data;
using GreatWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreatWeb.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;
		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Category> objCategoryList = _db.Categories.ToList();
			return View(objCategoryList);
		}

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Category obj)
		{
			if (obj.Name == obj.DisplayOrder.ToString())
			{
				ModelState.AddModelError("name", "The display order cannot exactly the name.");
			}
			if (ModelState.IsValid)
			{
				_db.Categories.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			Category? categoryFromDb = _db.Categories.Find(id);
			//Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
			//Category? categoryFromDb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();

			if (categoryFromDb == null)
			{
				return NotFound();
			}
			return View(categoryFromDb);
		}
		[HttpPost]
		public IActionResult Edit(Category obj)
		{
			if (ModelState.IsValid)
			{
				_db.Categories.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}