using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityVC.Controllers
{
    public class SquareNumberActivityController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public async Task<IActionResult> SaySquare(int inputNumber)
        {
            return View(viewName: "Index", model: (inputNumber * inputNumber * inputNumber));
        }
    }
}
