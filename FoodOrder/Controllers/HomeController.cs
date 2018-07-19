using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Models;
using Data.Services;

namespace FoodOrder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderServices _orderServices;

        public HomeController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            
            ViewData["Message"] = "Bajs";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
