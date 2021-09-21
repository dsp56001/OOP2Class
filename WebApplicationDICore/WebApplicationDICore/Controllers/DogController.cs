using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDICore.Models;
using Microsoft.AspNetCore.Http;

namespace WebApplicationDICore.Controllers
{
    public class DogController : Controller
    {
        protected static IDog _dog;

        protected static IEnumerable<IDog> dogs;

        public DogController(IDog dog)
        {
            
            dogs ??= new List<Dog>()
            {
                new Dog(),
                new Dog() { Name="milo", Age=2},
                new Dog() { Name="roover", Age=3}
            };
            
            //_dog ??= dog; //same as below
            if (_dog == null)
            {
                _dog = dog; //injected dog
            }
        }

        public IActionResult List()
        {
            return View(dogs);
        }

        public IActionResult Index()
        {
            return View("DogHome", _dog);
        }

        public IActionResult Edit(int? id)
        {
            _dog = dogs.Where<IDog>(d => d.DogID == id).FirstOrDefault();
            return View("Edit", _dog);
        }

        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            _dog = dog;
            return View("Edit", _dog);
        }
    }
}
