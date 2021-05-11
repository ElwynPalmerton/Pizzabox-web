using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]/[action]")]
    public class CheckoutController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public CheckoutController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index ()
        {
            return View("checkout");
        }
        
        [HttpGet]
        [HttpPost]
        public IActionResult Create ()   
        {   
            ViewBag.title = "CheckoutController - Create / Post";
            
            return View("Test");
        }
    }
}