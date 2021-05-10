using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;


namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class StorePortalController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public StorePortalController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {
            var stores = new StoreViewModel();
            stores.Load(_unitOfWork);
            //See order Controller...?
            return View("storeportal", stores);


   
        }

        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create ()   //CustomerViewModel order  
        {   //The form as posted is "Model Bound to the OrderViewModel order"

            ViewBag.title = "StorePortalController - Create / Post";
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