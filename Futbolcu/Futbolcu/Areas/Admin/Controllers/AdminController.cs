using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futbolcu.data;
using Futbolcu.Models;
using Futbolcu.Extensions;
using static Futbolcu.Utilities.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
 
using Microsoft.AspNetCore.Authorization;
using Futbolcu.Models.PostVM;

namespace Futbolcu.Areas.Admin.Controllers
{


    [Area("Admin")]
    [Authorize(Roles = SD.AdminRole)]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PostContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public AdminController(UserManager<ApplicationUser> userManager,
                                RoleManager<IdentityRole> roleManager,
                                 PostContext context,
                                 SignInManager<ApplicationUser> signInManager,
                                 IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _env = env;
        }
        // GET: Admin
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Index(LoginModel loginModel)

        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginModel);
            }
            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RemenberMe, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Not dear user, you were locked out for 5 minutes. Please, be patient!");
                return View(loginModel);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginModel);
            }
            return RedirectToAction("Details", "Admin");
        }

        // GET: Admin/Details/5
        public ActionResult Details()
        {
            var vm = new PostVM()
            {
                Posts = _context.Posts.ToList(),
                Category = _context.Categories.ToList(),
                



            };
            return View(vm);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.Category = _context.Categories;
            return View();
        }

        // POST: Admin/Create
        [HttpPost]

        public async Task<ActionResult> Create([Bind(include:"Id,Title,Description,Date,CategoryId,Count,Video")]Post post, IFormFile Photo)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                ViewBag.Category = _context.Categories;

                return View(post);
            }
             
            
             
            
                if (!Photo.IsImages())
                {
                    ModelState.AddModelError("", "Model is not valid");
                    ViewBag.Category = _context.Categories;

                    return View(post);
                }

                post.Image = await Photo.SaveImagesAsync(_env.WebRootPath, "Product");

            _context.Add(post);

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Admin");


        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Details", "Admin");
            }

            var product = await _context.Posts.FindAsync(id);
            if (product == null)
            {
                return RedirectToAction("Details", "Admin");
            }
            RemoveFile(_env.WebRootPath, product.Image);
            _context.Posts.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Admin");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Details", "Admin");
            }
            var product = _context.Posts.Find(id);
            if (product == null)
            {
                return RedirectToAction("Details", "Admin");
            }
            ViewBag.image =  _context.Posts.Where(p => p.Id == id).First().Category.Name; ;
            ViewBag.Category = _context.Categories;
            return View(product);
        }


        [HttpPost]
        public async Task<ActionResult> Edit([Bind(include: "Id,Title,Description,Date,CategoryId,Count,Video")]Post product, IFormFile Photo)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                ViewBag.image = _context.Posts.Where(p => p.Id == product.Id).First().Category.Name;
                ViewBag.Category = _context.Categories;
                return View(product);
            }
            var productDb = _context.Posts.Find(product.Id);
            productDb.Title = product.Title;
            productDb.Description = product.Description;
            productDb.CategoryId = product.CategoryId;
            productDb.Date = product.Date;
            productDb.Count = product.Count;
            productDb.Video = product.Video;
            if (Photo == null)
            {
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Admin");
            }
             
                if (!Photo.IsImages())
                {
                    ModelState.AddModelError("", "Model is not valid");
                    ViewBag.Category = _context.Categories;

                    return View(product);
                }
            RemoveFile(_env.WebRootPath, productDb.Image);

            productDb.Image = await Photo.SaveImagesAsync(_env.WebRootPath, "Product");
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Admin");
        }

    }
}