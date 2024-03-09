//using Leavewithasmilecleaningwebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Leavewithasmilecleaningwebsite.Controllers
{
    public class HomeController : Controller
    {
        //private LeavewithasmilecleaningwebsiteContext context { get; set; }

        //public HomeController(LeavewithasmilecleaningwebsiteContext ctx)
        //{
        //    context = ctx;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}