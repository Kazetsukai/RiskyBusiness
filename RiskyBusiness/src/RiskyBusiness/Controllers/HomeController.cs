using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
			var risks = _context.Risks.ToList();

			return View(risks);
		}

        [HttpPost]
        public IActionResult AddRisk(Risks risk)
        {
            risk.date_raised = DateTime.Now;
            risk.owner = "Frodo";
            risk.status = "Open";
            
            _context.Risks.Add(risk);
            _context.SaveChanges();
            return new JsonResult(risk);
        }

		public IActionResult Error()
		{
			return View("~/Views/Shared/Error.cshtml");
		}
	}
}
