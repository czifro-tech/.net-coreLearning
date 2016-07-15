using System;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{

    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ValueReturn()
        {
            return View();
        }
    }
}