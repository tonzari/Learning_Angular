using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PluralSight_AngularCourse.Services;
using PluralSight_AngularCourse.ViewModels;

namespace PluralSight_AngularCourse.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Notice there are TWO Contact() IActionResults here.
        // How does the system know what to do? Attributes!
        // The attributes tell MVC what kind of request is coming in.
        // When the browser sends back information in the form of a POST (which is declared in the razor view form method attribute)
        // ... MVC will see that and use the correct Action.
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // send the email
                _mailService.SendMessage("antoniomanzari@gmail.com", model.Subject, model.Message);
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
    }
}
