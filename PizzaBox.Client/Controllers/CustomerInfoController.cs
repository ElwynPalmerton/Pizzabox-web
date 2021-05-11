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
            return View("Customer", customer);
        }
        
        [HttpPost]
        public IActionResult Create (CustomerViewModel customer) 
        {
            ViewBag.title = customer.ToString();


            var newCustomer = new Customer(customer.CustomerName, customer.Address, customer.PhoneNumber);
            _unitOfWork.Customers.Insert(newCustomer);
            _unitOfWork.Save();

            Order newOrder = new Order(){
                Customer = newCustomer
            };

            _unitOfWork.Orders.Insert(newOrder);
            _unitOfWork.Save();

            return Redirect("/ChoosePizza/Index/" + newOrder.EntityId);
        }
    }
}




