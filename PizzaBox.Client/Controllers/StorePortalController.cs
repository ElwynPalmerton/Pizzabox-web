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
        public IActionResult Create ()   //CustomerViewModel order  
        { 
            ViewBag.title = "StorePortalController - Create / Post";
            return View("Test");
        }
    }
}