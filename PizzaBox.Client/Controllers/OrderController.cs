using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public OrderController(UnitOfWork unitOfWork)
        {
            //FB: The runtime controls the instance of UnitOfWork.
            //The environment where OrderController is running.
            //Dependency Injection - an implementation of the D in SOLID which is Dependency inversion.
            // _logger = logger;
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {
            var order = new OrderViewModel();

            order.Load(_unitOfWork);
            return View("order", order);
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create (OrderViewModel order)  
        {   //The form as posted is "Model Bound to the OrderViewModel order"

        sc.WriteLine("Selected: " + order.SelectionsToString());

            if (ModelState.IsValid)
            {

//                 var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
//                 var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
// 
//                 var toppings = new List<Topping>();
//  
//                 foreach (var item in order.SelectedToppings)
//                 {
//                     var newTops = _unitOfWork.Toppings.Select(c => c.Name == item).First();
//                     toppings.Add(newTop);
//                 }
// 
//                 var newPizza = new CustomPizza{Crust = crust, Size = size, Toppings = toppings};
//                 //*The Pizzas are all commented out, entirely.
//                 
//                 var newOrder = new Order {Pizzas = new List<Pizza> {newPizza}};  
//                 //*Order exists but does not have any fields or properties yet.
//                 
// 
//                 _unitOfWork.Orders.Insert(newOrder);
//                 //*Orders has not been included on the UnitOfWork yet.
//                 _unitOfWork.Save();

            
                // return View("AddPizza");
                ViewBag.title = $"Valid Selections: {order.SelectionsToString()}";
                return View("Test");


            }  
           
        
           
            ViewBag.title = $"Selections: {order.SelectionsToString()}";
            return View("Test");

        }
    }
}

