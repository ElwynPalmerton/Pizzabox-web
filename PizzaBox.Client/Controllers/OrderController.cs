using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
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
        public IActionResult Create (OrderViewModel order)  
        {   
            var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
            var size = _unitOfWork.Sizes.Select(c => c.Name == order.SelectedSize).First();
            var toppings = new List<Topping>();

            foreach (var item in order.SelectedToppings)
            {
                var newTop = _unitOfWork.Toppings.Select(c => c.Name == item.ToString()).First();
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

            
            var newCustomer = new Customer(order.CustomerName, order.Address, order.PhoneNumber);
            _unitOfWork.Customers.Insert(newCustomer);
            _unitOfWork.Save();
            
            var pizzasList = new List<APizza>();
            pizzasList.Add(newPizza);


            var store = _unitOfWork.Stores.Select(c => c.Name == order.SelectedStore).First();


            Order newOrder = new Order(){
                Customer = newCustomer,
                Pizzas = pizzasList,
                Store = store
            };

            _unitOfWork.Orders.Insert(newOrder);
            _unitOfWork.Save();
            
            ViewBag.title = $"Valid Selections: {order.SelectionsToString()}";
            
            return View("Test");
        }
    }
}