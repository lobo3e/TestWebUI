using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebUI.Models;

namespace TestWebUI.Controllers
{
    public class ValuesController : Controller
    {
        List<ValuesModel> vm = new List<ValuesModel>();
        private int _id;

        // GET: Values
        public ActionResult Index()
        {
            vm.Add(new ValuesModel() { ID = 4, Value = "test values" });

            return View(vm);
        }

        // GET: Values/Details/5
        public ActionResult Details(string id)
        {
            //_id = id;
            return View();
        }

        // GET: Values/Create
        public ActionResult Create()
        {
            vm.Add(new ValuesModel() { ID = 45, Value = "test2" });
            Response.WriteAsync(vm[0].ID + " " + vm[0].Value);

            return View();
        }

        // POST: Values/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Values/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Values/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                
                 //string id = collection["ID"];
                string value = collection["Value"];

                if (vm[id].Equals(id))
                {

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Values/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Values/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}