using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{
    [Route("[controller]/[action]/{orderID}")]
    public class ChoosePizzaController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ChoosePizzaController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index (int orderID)
        {
            var pizzas = new PizzaViewModel(){
                orderNumber = orderID,
            };
            pizzas.Load();

            return View("choosePizza", pizzas);
        }
    }
}