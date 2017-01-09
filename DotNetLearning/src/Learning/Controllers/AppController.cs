using System;
using Microsoft.AspNetCore.Mvc;
using Learning.ViewModels;
using Learning.Services;

namespace Learning.Controllers
{

    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService service)
        {
            _mailService = service;
        }
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

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
            var email = Startup.Configuration["AppSet:Email"];

                if (string.IsNullOrEmpty(email))
                {
                    ModelState.AddModelError("", "Could not send email, config");
                }

                if(_mailService.SendMail(
                email,
                email,
                $"Contact Page from {model.Name} ({model.Email})",
                model.Message))
                {
                    ModelState.Clear();

                    ViewData["Message"] = "You did it!! Mail was sent ^_^";
                }

            }
            return View();
        }
    }
}