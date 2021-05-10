using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;




namespace PizzaBox.Client.Controllers
{

    [Route("[controller]/[action]")]
    public class SelectStoreController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public SelectStoreController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Index ()
        {
            var stores = new StoreViewModel();
            stores.Load(_unitOfWork);
            return View("selectstore", stores);
        }

        
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Create (StoreViewModel store)  
        {
            sc.WriteLine(store.SelectedStore.ToString());

            ViewBag.title = $"SelectStoreController - Create / Post {store.SelectedStore.ToString()}";
            return View("Test");
//             if (ModelState.IsValid)
//             {
//                  return RedirectToRoute("order");   // the customer id as a parameter.
//             }
//             return View("CustomerInfo");

        }
    }
}