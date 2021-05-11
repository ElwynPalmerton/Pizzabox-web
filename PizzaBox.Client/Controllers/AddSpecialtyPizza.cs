using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;
using System.Collections.Generic;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class AddSpecialtyPizzaController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public AddSpecialtyPizzaController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Index (PizzaViewModel pizzaType)
        {
            var crust = _unitOfWork.Crusts.Select(c => c.Name == "Thin").First();
            var size = _unitOfWork.Sizes.Select(c => c.Name == "Medium").First();

            Topping top1;
            Topping top2;
            var toppings = new List<Topping>();

            if (pizzaType.SelectedPizzaType =="Meat Pizza")
            {
                //Get the two meat toppings.
                top1 = _unitOfWork.Toppings.Select(c => c.Name == "Pepperoni").First();
                top2 = _unitOfWork.Toppings.Select(c => c.Name == "Sausage").First();

                toppings.Add(top1);
                toppings.Add(top2);

                var newMeatPizza = new CustomPizza()
                {
                    Name="Meat Pizza",
                    Crust = crust, 
                    Size = size, 
                    Toppings = toppings
                };


                _unitOfWork.Pizzas.Insert(newMeatPizza);
                _unitOfWork.Save();

                var orderID = pizzaType.orderNumber;

                var order = _unitOfWork.Orders.Select(c => c.EntityId == orderID);
                order.First();

                _unitOfWork.Save();
            }
            else if (pizzaType.SelectedPizzaType == "Veggie Lovers Pizza")
            {
                //Get two Veggie Toppings.
                top1 = _unitOfWork.Toppings.Select(c => c.Name == "Peppers").First();
                top2 = _unitOfWork.Toppings.Select(c => c.Name == "Spinach").First();

                toppings.Add(top1);
                toppings.Add(top2);

                var newVeggiePizza = new CustomPizza()
                {
                    Name = "Veggie Pizza",
                    Crust = crust, 
                    Size = size, 
                    Toppings = toppings
                };


                _unitOfWork.Pizzas.Insert(newVeggiePizza);
                _unitOfWork.Save();

                var orderID = pizzaType.orderNumber;

                var order = _unitOfWork.Orders.Select(c => c.EntityId == orderID).First();

                _unitOfWork.Save();

            }

            ViewBag.title = $"Valid Selections: {pizzaType.SelectedPizzaType}";
           
            return View("test");
        }
    }
}
