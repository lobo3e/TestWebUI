using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebUI.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action..."; //View();
        }

       // public string Welcome()
       // {
       //     return "This is the welcome action method...";
       // }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode( $"Name:{name} Id: {ID}");
        }
    }
}