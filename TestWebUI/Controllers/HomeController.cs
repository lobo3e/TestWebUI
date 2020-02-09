using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWebUI.Models;

namespace TestWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<User> users = new List<User>();
            var u = new User()
            {
                ID = 1,
                Name = "a",
                Surname = "aa",
                Number = 111
            };

            var u2 = new User()
            {
                ID = 2,
                Name = "b",
                Surname = "bb",
                Number = 222
            };
            var u3 = new User()
            {
                ID = 3,
                Name = "c",
                Surname = "cc",
                Number = 333
            };
            users.Add(u);
            users.Add(u2);
            users.Add(u3);

            return View(users);
        }
    

        public IActionResult Privacy()
        {
            var uu = new User()
            {
                ID = 1,
                Name = "a",
                Surname = "aa",
                Number = 111
            };
            ViewBag.User = uu;
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
