using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using System;
using PizzaBox.Storage;


//Add the repositor reference.

namespace PizzaBox.Storing.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        // private readonly FileRepository _fileRepository = new FileRepository();
        // private const string _path = @"data/pizzas.xml";

        private readonly PizzaBoxContext _context;

        public CustomerRepository(PizzaBoxContext context)    //Need to fix up the PizzaBoxContext.
        {
            _context = context;
        }
           public IEnumerable<Customer> Select(Func<Customer, bool> filter)
        {
            return _context.Customers.Where(filter);
            //I need this in the other repositories too.
        }

        public bool Insert(Customer newCustomer)
        {
            //
            _context.Customers.Add(newCustomer);
            throw new System.NotImplementedException();
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