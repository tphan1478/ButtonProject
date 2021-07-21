using ButtonProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ButtonProject.Controllers
{
    public class HomeController : Controller
    {
        public static List<ButtonInfo> AllInfo = new List<ButtonInfo>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.AllInfo = AllInfo;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }

        [HttpPost("createForm")]
        public IActionResult createForm(ButtonInfo newButton)
        {
            if (ModelState.IsValid)
            {
                AllInfo.Add(newButton);
                return View("CompletedForm",newButton);
            }
            else
            {
                
                return View("Index");
            }
        }
    }
}
