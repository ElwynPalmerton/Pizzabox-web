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
        public IActionResult Create (StoreViewModel store)  
        {
            ViewBag.title = $"SelectStoreController - Create / Post {store.SelectedStore.ToString()}";
            return View("Test");
        }
    }
}