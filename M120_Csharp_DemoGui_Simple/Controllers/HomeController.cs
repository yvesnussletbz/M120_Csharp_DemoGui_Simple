using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemoM120.Models;

namespace MVCDemoM120.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WorkLogEntry(WorkLogEntry model)
        {
            // in a real application we would save the WorkLogEntry from the business layer
            // var bi = new WorkLogEntryService();
            // bi.SaveWorkLog();

            // in this prototype we just return the model again
            ViewBag.listOfProjects = model.Projects;
            return View(model);
        }


        public IActionResult WorkLogEntry()
        {
            // in a real application we would load the WorkLogEntry from the business layer
            // var bi = new WorkLogEntryService();
            // return View(bi.GetWorkLogEntry());

            // in this prototype we create the model right herer
            var model = new WorkLogEntry();
            ViewBag.listOfProjects = model.Projects;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
