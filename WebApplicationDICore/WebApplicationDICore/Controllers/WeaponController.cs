using DIDemo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDICore.Controllers
{
    public class WeaponController : Controller
    {

        IWeapon _weapon;

        public WeaponController()
        {
            
        }

        public IActionResult Index(IWeapon weapon)
        {
            return View(_weapon);
        }

        public IActionResult Edit(IWeapon weapon)
        {
            _weapon = weapon;
            return View(_weapon);
        }

        public IActionResult List(IWeapon weapon)
        {
            IEnumerable<IWeapon> weapons = new List<IWeapon>()
            {
                new Katana(),
                new Sword()
            };
            return View(weapons);
        }

    }
}
