using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;
using PizzaBox.Domain.Models;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class CustomerController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public CustomerController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {

            var customer = new CustomerViewModel();

//             order.Load(_unitOfWork);
//             return View("order", order);
            //See order Controller...?
            return View("Customer", customer);


        }

        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create (CustomerViewModel customer) 
        {
            //Send the Customer to the Order Controller...?
                //Just pass as an argument for now...?
            //Add the data Validation.

            ViewBag.title = customer.ToString();


            var newCustomer = new Customer(customer.CustomerName, customer.Address, customer.PhoneNumber);
            _unitOfWork.Customers.Insert(newCustomer);
            _unitOfWork.Save();

            return View("Test");

// Add data validation:
//          if (ModelState.IsValid)
//          {
//              return RedirectToRoute("order");   // the customer id as a parameter.
//          }
// 
//             return View("CustomerInfo");

        }
    }
}


//             //*https://techfunda.com/howto/235/redirect-user-to-another-route-url