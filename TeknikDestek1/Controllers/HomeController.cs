using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TeknikDestek1.Data;
using TeknikDestek1.Models;

namespace TeknikDestek1.Controllers

{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Document.Include(d => d.Category).Include(d => d.Writer);
            return View( await applicationDbContext.ToListAsync());
            
            
            
            
            
            //List<Document> models = new List<Document>();

            //foreach (var item in COLLECTION)
            //{
                
            //}
            // var model = new Document();
            // model.DocumentName = _context.Document.ToString();
            // model.DocumentBanner = _context.Document.ToString();
            //model.DocumentInfo = _context.Document.ToString();
            //model.DocumentSubject = _context.Document.ToString();
            //model.DocumentVideo = _context.Document.ToString();

            //return View(model);
           
            
        }
       

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize]
        public IActionResult Admin()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
