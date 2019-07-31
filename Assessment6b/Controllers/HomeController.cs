using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment6b.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment6b.Controllers
{
    public class HomeController : Controller
    {
        private readonly JellyBeanContext _context;

        public HomeController(JellyBeanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> JellyBean()
        {
            return View(await _context.JellyBeans.ToListAsync());
        }

        public async Task<IActionResult> CreateJelly(JellyBean jellyBean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jellyBean);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(JellyBean));
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
