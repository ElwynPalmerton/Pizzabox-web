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
        {   
            sc.WriteLine("Selected: " + order.SelectionsToString());
            //SelectedCrust
            //SelectedSize
            //SelectedToppings
        
            


            // if (ModelState.IsValid)
            // {

                var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
                var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
   
                sc.WriteLine("Crust: " + crust.EntityId);
                sc.WriteLine("Size: " + size.EntityId);

                var toppings = new List<Topping>();
 
                foreach (var item in order.SelectedToppings)
                {
                    sc.WriteLine("Topping: " + item.ToString());
              
                    var newTop = _unitOfWork.Toppings.Select(c => c.Name == item.ToString()).First();
                    sc.WriteLine("Topping: " + newTop.EntityId);
                    
                    toppings.Add(newTop);
                }
// 
                var newPizza = new CustomPizza()
                {
                    Crust = crust, 
                    Size = size, 
                    Toppings = toppings
                };

                _unitOfWork.Pizzas.Insert(newPizza);
                _unitOfWork.Save();

                sc.WriteLine(newPizza.ToString());





                // var newOrder = new Order {Pizzas = new List<Pizza> {newPizza}};  
//                 //*Order exists but does not have any fields or properties yet.
//                 
// 
//                 _unitOfWork.Orders.Insert(newOrder);
//                 //*Orders has not been included on the UnitOfWork yet.
//                 _unitOfWork.Save();

            
                // return View("AddPizza");
                ViewBag.title = $"Valid Selections: {order.SelectionsToString()}";
                return View("Test");


            // }  End of ModelState.IsValid block.
            //Send the order view again if !ModelState.IsValid:
            //return View("order");  //???

        }
    }
}

            //FB: The runtime controls the instance of UnitOfWork.
            //The environment where OrderController is running.
            //Dependency Injection - an implementation of the D in SOLID which is Dependency inversion.
            // _logger = logger;

            // in Create: 
            //The form as posted is "Model Bound to the OrderViewModel order"