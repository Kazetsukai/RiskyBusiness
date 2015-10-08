using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace RiskyBusiness.Controllers
{
    public class HomeController : Controller
    {
        private Risks_issues_DEVLContext _context;

        public HomeController(Risks_issues_DEVLContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
