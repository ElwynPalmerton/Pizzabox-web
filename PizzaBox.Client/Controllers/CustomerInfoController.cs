using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


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

            ViewBag.title = $"CustomerInfoController {customer.CustomerName} - {customer.PhoneNumber} - {customer.Address}";
            return View("Test");

            //*Customer is not added on the UnitOfWork yet...


//          if (ModelState.IsValid)
//          {
//              return RedirectToRoute("order");   // the customer id as a parameter.
//          }
// 
//             //*https://techfunda.com/howto/235/redirect-user-to-another-route-url
// 
//             return View("CustomerInfo");
          

        }
    }
}