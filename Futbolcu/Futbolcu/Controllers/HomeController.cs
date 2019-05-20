using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Futbolcu.Models;
using Microsoft.AspNetCore.Identity;
using Futbolcu.data;
using Futbolcu.Models.PostVM;
 

namespace Futbolcu.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(PostContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            var vm = new PostVM()
            {
                Posts = _context.Posts,
                Category = _context.Categories
            };
            ViewBag.userId = _userManager.GetUserId(HttpContext.User);
            return View(vm);
        }
        public ActionResult AjaxSearch(string query)
        {
            List<Post> db = new List<Post>();

           db  = _context.Posts.Where(p => p.Title.Contains(query)).ToList();
            var vm = new PostVM()
            {
                Category = _context.Categories,
                Posts=db
            };

            if (db.Count > 0) return PartialView("_PartialAjaxSearch", vm);

            else
                return Content("Sorgu tapilmadi!");

        }
        public ActionResult AjaxCategory(string query)
        {
            List<Post> db = new List<Post>();
             
            db = _context.Posts.Where(p => p.Category.Name==query).ToList();
            var vm = new PostVM()
            {
                Category = _context.Categories,
                Posts = db
            };

            if (db.Count > 0) return PartialView("_PartialAjaxSearch", vm);

            else
                return Content("Sorgu tapilmadi!");

        }
        public IActionResult Kulub()
        {
            return View();
        }
        public IActionResult LigaTable()
        {
            
            return View(_context.Countries.ToList());
        }
        public IActionResult About()
        {
            return View();
        }
        public async Task<ActionResult> Details(int? Id)
        {
            var product = await _context.Posts.FindAsync(Id);

            //if (product==null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            product.Count += 1;
            _context.SaveChanges();
            ViewBag.Post=product ;
            var vm = new DetailsVM() {
                Post=_context.Posts,
                Category=_context.Categories
            };
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
