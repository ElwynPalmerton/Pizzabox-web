using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{
    [Route("[controller]/[action]")]
    public class AddPizzaController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        public AddPizzaController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index ()
        {
            return View("AddPizza");
        }
        
        [HttpPost]
        public IActionResult Create ()
        {  
            ViewBag.title = "AddPizzaController - Create / Post";
            return View("Test");
        }
    }
}