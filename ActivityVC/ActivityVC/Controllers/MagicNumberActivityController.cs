using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityVC.Controllers
{
    public class MagicNumberActivityController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public async Task<IActionResult> CalcMagicNumber(int inputLower, int inputUpper)
        {
            Random generator = new Random();
            if (inputLower > inputUpper)
            {
                return View(viewName: "Index", model:
                                    -999);
            }
            return View(viewName: "Index", model:
                                generator.Next(inputLower-1, inputUpper+1));
        }
    }
}
