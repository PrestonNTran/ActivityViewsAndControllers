using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityVC.Controllers
{
    public class DatesActivity : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: DateTime.Now);
        }
        [HttpPost]
        public async Task<IActionResult> DateMagic(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: inputBirthday);
        }
        
    }
}
