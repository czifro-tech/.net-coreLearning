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
        }
}