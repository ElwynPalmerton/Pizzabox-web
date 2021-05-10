using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class FindCustomerController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public FindCustomerController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {
            var customer = new CustomerViewModel();
            return View("findcustomer");
        }

        
        [HttpGet]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create (CustomerViewModel customer)  
        { 

            var foundCustomer = _unitOfWork.Customers.Select(c => c.Name == customer.CustomerName).FirstOrDefault();
      
            if (foundCustomer != null)
            {
                ViewBag.title = $"Find Customer - Found Customer: {foundCustomer.ToString()} ";
            }
            else
            {
                ViewBag.title = $"Find Customer route - Customer not Found";
            }

            return View("Test");
        
        }
    }
}