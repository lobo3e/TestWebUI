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
        public List<User> Users { get; set; }
        private bool listCreated = false;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private void CreateUsers()
        {

            if (!listCreated)
            {
                listCreated = true;
                Users = new List<User>();
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
                Users.Add(u);
                Users.Add(u2);
                Users.Add(u3);

            }
        }

        public IActionResult Index()
        {
            CreateUsers();
            return View(Users);
        }

        public IActionResult Index1(string id)
        {
            //remove user from list
            return View(Users);
        }
    
         [HttpPost]
        public IActionResult Post(string id)
        {
            return RedirectToAction(nameof(Index));
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
