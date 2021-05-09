using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using PizzaBox.Storage;
using System;
using PizzaBox.Domain.Abstracts;
using sc = System.Console;
// using PizzaBox.Domain.Models;



//Add the repositor reference.

namespace PizzaBox.Storing.Repositories
{
    public class PizzaRepository : IRepository<APizza>
    {
        private readonly PizzaBoxContext _context;

        public PizzaRepository(PizzaBoxContext context)
        {
                _context = context;
        }

        public bool Insert(APizza newPizza)
        {
            sc.WriteLine("Saving Pizza");
            _context.Pizzas.Add(newPizza);
            return true;
            // throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<APizza> Select(Func<APizza, bool> filter)
        {
            throw new NotImplementedException();
        }

        APizza IRepository<APizza>.Update()
        {
            throw new NotImplementedException();
        }
    }
}

