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
            //See order Controller...?
            return View("CustomerAccount");
        }

        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create ()   //CustomerViewModel order  
        {   //The form as posted is "Model Bound to the OrderViewModel order"

            ViewBag.title = "CustomerAccountController - Create / Post";
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