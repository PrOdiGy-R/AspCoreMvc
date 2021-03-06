using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspCore.Data;
using AspCore.Models;

namespace AspCore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly NorthwindDbContext _context;

        public CategoriesController(NorthwindDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
