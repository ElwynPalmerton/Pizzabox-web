using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using PizzaBox.Storage;
using System;


//Add the repositor reference.

namespace PizzaBox.Storing.Repositories
{
    public class ToppingRepository : IRepository<Topping>
    {
       
        private readonly PizzaBoxContext _context;

        public delegate bool ToppingDelegate(Topping topping);

        public ToppingRepository(PizzaBoxContext context)
        {
            _context = context;
        }
       
       public IEnumerable<Topping> Select(Func<Topping, bool> filter)
        {
            
            return _context.Toppings.Where(filter);

        }
        public bool Insert(Topping t)
        {
            throw new System.NotImplementedException();
        }

        public Topping Update()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}
