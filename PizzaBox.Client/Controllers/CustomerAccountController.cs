using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{
    [Route("[controller]/[action]")]
    public class CustomerAccountController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public CustomerAccountController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index ()
        {
            return View("CustomerAccount");
        }
        
        [HttpPost]
        public IActionResult Create ()   
        { 
            ViewBag.title = "CustomerAccountController - Create / Post";
            return View("Test");
        }
    }
}