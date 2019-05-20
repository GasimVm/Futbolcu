using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futbolcu.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Futbolcu.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Permissions;
using System.Data;

namespace Futbolcu.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.AdminRole)]

    public class CategoryController : Controller
    {
        private readonly PostContext _context;
        public CategoryController(PostContext context)
        {
            _context = context;

        }

        // GET: Category
        public ActionResult Index()
        {
            return View(_context.Categories);
        }


        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
    
        [HttpPost]
        public ActionResult Create([Bind(include: "Name")]Category category)
        {
            if (category.Name == null) return View(category);
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");

        }

        public ActionResult Edit(int id)
        {
            return View(_context.Categories.Find(id));
        }
        [HttpPost]
        public ActionResult Edit([Bind(include: "Id,Name")] Category category)
        {
            if (category.Name == null) return View(category);
            var categorydb = _context.Categories.Where(p => p.Id == category.Id).First();
            categorydb.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");

        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            Category category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");

        }


    }
}