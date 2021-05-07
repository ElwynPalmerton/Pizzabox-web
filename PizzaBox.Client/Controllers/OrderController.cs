using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]")]
    public class OrderController : Controller
    {
        // private readonly ILogger<OrderController> _logger;
        private readonly UnitOfWork _unitOfWork;

        //Gets this from the runtime.
        public OrderController(UnitOfWork unitOfWork)
        {
            //FB: The runtime controls the instance of UnitOfWork.
            //The environment where OrderController is running.
            //Dependency Injection - an implementation of the D in SOLID which is Dependency inversion.
            // _logger = logger;
            _unitOfWork = unitOfWork;
        }


   
        [HttpPost]
        public IActionResult Index (OrderViewModel order)
        {
            //I'm not sure if this route is set-up correctly or if this is what
            //Fred did or not.
            //
            // var order = new OrderViewModel();
            order.Load(_unitOfWork);


            return View("order", order);
   
        }

        [HttpGet]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (OrderViewModel order)  
        {   //The form as posted is "Model Bound to the OrderViewModel order"

            if (ModelState.IsValid)
            {
                //(1:46:09 in the video  for Thursday 5/7/21)
                //I didn't add the Orders Repository onto the UofW yet.
      
                //COMMENTED OUT TEMPORARILY//
                //COMMENTED OUT TEMPORARILY//
                //COMMENTED OUT TEMPORARILY//
                //COMMENTED OUT TEMPORARILY//
                // _unitOfWork.Orders.Add(order);
                // _unitOfWork.Save();
                return View("checkout");
            }

            order.Load(_unitOfWork);

            return View("order", order);   

            // var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
            // var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
            // foreach (var item in order.SelectedToppings)
            // {
            //     toppings.Add(_unitOfWork.Toppings)
            // }
            
            // var newPizza = new Pizza{Crust = crust, Size = size, Toppings = toppings};
            // var newOrder = new Order {Pizzas = new List<Pizza> {newPizza}}
            
            // _unitOfWork.Orders.Insert(newOrder);
            // _unitOfWork.Save();
        }
    }
}