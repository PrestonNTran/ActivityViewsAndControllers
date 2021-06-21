using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityVC.Controllers
{
    public class FinalActivitiesController : Controller
    {
        public async Task<IActionResult> Activity5()
        {
            return View(viewName: "Activity5", model: "Please enter a string.");
        }
        [HttpPost]
        public async Task<IActionResult> SayHello(string inputString)
        {
            return View(viewName: "Activity5", model: "Length of string: " + inputString.Length);
        }

        public async Task<IActionResult> Activity6()
        {
            return View(viewName: "Activity6", model: " ");
        }
        [HttpPost]

        public async Task<IActionResult> Concatenate(string firstName, string lastName)
        {
            return View(viewName: "Activity6", model: firstName + lastName);
        }

        public async Task<IActionResult> Activity7()
        {
            return View(viewName: "Activity7", model: " ");
        }
        [HttpPost]

        public async Task<IActionResult> AbsNameAge(string lastName, int age)
        {
            int result = Math.Abs(lastName.Length - age);
            return View(viewName: "Activity7", model: result);
        }

        public async Task<IActionResult> Activity8()
        {
            return View(viewName: "Activity8", model: " ");
        }
        [HttpPost]

        public async Task<IActionResult> CalcAge(string birthday)
        {
            
            return View(viewName: "Activity8", model: );
        }
    }
}
