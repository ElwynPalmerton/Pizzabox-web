using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using PizzaBox.Storage;
using System;
using PizzaBox.Domain.Abstracts;
using sc = System.Console;

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
            _context.Pizzas.Add(newPizza);
            return true;
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

