using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DefaultMVCCore.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DefaultMVCCore.Controllers
{
    public class ResultTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public ResultTypeController(ApplicationDbContext context,IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFound(int? id)
        {
            if(id.HasValue)
            {
                return View();
            }
            else
            {
                return Redirect("https://www.tutorialsteacher.com/");
                return NotFound();
            }
        }
        public ContentResult Content()
        {
            return Content("https://www.google.com/");
        }
        public JsonResult Json()
        {
            var person = _context.Person.Where(d => d.FirstName.StartsWith("s")).ToList();
            return Json();
        }
        public IActionResult File()
        {
            string path = _webHost.ContentRootPath;
            string fullPath = Path.Combine(path,"appsettings.json");
            var content = System.IO.File.ReadAllBytes(fullPath);
            return File(content, "application/json");
        }
    }
}
