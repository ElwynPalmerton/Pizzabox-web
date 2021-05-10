using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class ChoosePizzaController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ChoosePizzaController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {
            var pizzas = new PizzaViewModel();
            pizzas.Load();

            //See order Controller...?
            return View("choosePizza", pizzas);
        }

        
        [HttpGet]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create (PizzaViewModel pizzaType)   //CustomerViewModel order  
        {   //The form as posted is "Model Bound to the OrderViewModel order"

            var pizza = pizzaType.SelectedPizzaType;

            ViewBag.title = $"ChoosePizzaController - Create / Post {pizza}";
            return View("Test");
//             if (ModelState.IsValid)
//             {
//                  return RedirectToRoute("order");   // the customer id as a parameter.
//             }
// 
//             //*https://techfunda.com/howto/235/redirect-user-to-another-route-url
// 
//             return View("CustomerInfo");
          

        }
    }
}