using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using System;
using PizzaBox.Storage;
using sc = System.Console;


//Add the repositor reference.

namespace PizzaBox.Storing.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {

        private readonly PizzaBoxContext _context;

        public CustomerRepository(PizzaBoxContext context) 
        {
            _context = context;
        }
        public IEnumerable<Customer> Select(Func<Customer, bool> filter)
        {
           return _context.Customers.Where(filter);
        }

        public bool Insert(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            return true;
        }

        public bool Insert()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        Customer IRepository<Customer>.Update()
        {
            throw new NotImplementedException();
        }
    }
}