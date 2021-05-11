using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using System;
using PizzaBox.Storage;
using sc = System.Console;

namespace PizzaBox.Storing.Repositories
{
    public class CrustRepository : IRepository<Crust>
    {
        private readonly PizzaBoxContext _context;

        public CrustRepository(PizzaBoxContext context)    //Need to fix up the PizzaBoxContext.
        {
            _context = context;
        }
        public IEnumerable<Crust> Select(Func<Crust, bool> filter)
        {
            return _context.Crusts.Where(filter);
        }

        public bool Insert(Crust c)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert()
        {
            var thinCrust = new Crust()
            {
                Name = "Thin Style",
                Price = 3.00M
            };

            _context.Crusts.Add(thinCrust);
            return true;
        }

        public Crust Update()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}