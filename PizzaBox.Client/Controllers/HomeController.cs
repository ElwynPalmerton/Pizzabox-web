using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
    [Route("/")]
    [Route("/Home")]
    [Route("/[action]")]
    [Route("Home/[action]")]
    // [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        private readonly UnitOfWork _unitOfWork;

       
        public HomeController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]       //This is called an action filter.  action for {url}/Home/Index
        public IActionResult Index()
        {
            // Returns the first page
            // "Click here to make an order"
            return View("index");
            // I think that Fred might have moved this around

//             var order = new OrderViewModel();
// 
//             order.Load(_unitOfWork);
//             return View("order", order);
        

        }


        //ViewData
        //TempData - for the lifetime of the request the tempdata is available.
        //TempData survives redirect until the final response is given (the lifetime of the request.)
        // return View("index", ViewBag.Order);
        //A weak typed view means that the view doesn't know what type of data it will receive.
        //It assumes that the action always gives it the right model.
        //ViewBag and ViewData only have the data one-way  - only survive action to view.
        //Three types of weakly-typed views.

        //IActionResult - The request is the one instantiating a method.
        //not executed by the code itself. These are known as actions.
        //IActionResult

        // Action for {url}/Home/Privacy 



 
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


//ViewData["Movie"] = movie;
// return View();