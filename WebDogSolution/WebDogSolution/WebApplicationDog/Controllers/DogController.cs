using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DogLibrary;

namespace WebApplicationDog.Controllers
{
    public class DogController : Controller
    {

        static Dog dog;

        public DogController()
        {
            if(dog== null)
             dog = new Dog();

        }
        
        // GET: Dog
        public ActionResult Index()
        {

            return View(dog);
        }

        // GET: Dog/Details/5
        public ActionResult Details(Dog d)
        {
            return View(dog);
        }

        // GET: Dog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dog/Edit/5
        public ActionResult Edit(Dog d)
        {
            return View(dog);
        }

        // POST: Dog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                dog.Name = collection["Name"];
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dog/Delete/5
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