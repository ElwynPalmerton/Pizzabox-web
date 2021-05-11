using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using sc = System.Console;
using PizzaBox.Storage;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly PizzaBoxContext _context;

        public OrderRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            return true;
        }   

        public IEnumerable<Order> Select(Func<Order, bool> filter)
        {
            return _context.Orders.Where(filter);
        }

        public Order Update()
        {
            throw new NotImplementedException();
        }
    }
}

