using DIDemo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Controllers
{
    public class WarriorController : Controller
    {
        protected IWarrior _warrior;

        public WarriorController(IWarrior warrior)
        {
            _warrior = warrior;
        }

        public IActionResult Index()
        {
            return View("WarriorHome", _warrior);
        }
    }
}
