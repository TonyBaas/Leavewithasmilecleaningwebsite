﻿
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace Leavewithasmilecleaningwebsite.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Commercial()
        {
            return View();
        }

        public IActionResult Residential()
        {
            return View();
        }
    }
}