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
    public class StoreRepository : IRepository<AStore>
    {
        private readonly PizzaBoxContext _context;

        public StoreRepository(PizzaBoxContext context)
        {
                _context = context;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Insert(AStore t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AStore> Select(Func<AStore, bool> filter)
        {
            return _context.Stores.Where(filter);
        }

        public AStore Update()
        {
            throw new NotImplementedException();
        }
    }
}

