using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDog.Controllers
{
    public class HelloController : Controller
    {
        string Result { get; set; }
        string Name { get; set; }


        public HelloController()
        {
            this.Name = "MVC!";
            SetResultString();
        }

        private void SetResultString()
        {
            
            Result = $"Hello {this.Name}";
        }

        public string Index(string Name)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                this.Name = Name;
                SetResultString();
            }
            return Result;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}