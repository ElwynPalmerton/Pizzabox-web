using PizzaBox.Domain.Models;
using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Storing;
using System.Linq;
using PizzaBox.Storage;
using System;


//Add the repositor reference.

namespace PizzaBox.Storing.Repositories
{
    public class SizeRepository : IRepository<Size>
    {
        private readonly FileRepository _fileRepository = new FileRepository();
        private const string _path = @"data/pizzas.xml";

        private readonly PizzaBoxContext _context;


        public SizeRepository(PizzaBoxContext context)
        {
            _context = context;
        }

            public IEnumerable<Size> Select(Func<Size, bool> filter)
        {   
            return _context.Sizes;     //Still need ef Core.
            throw new NotImplementedException();
        }
        public bool Insert()
        {
            throw new System.NotImplementedException();
        }

        public Size Update()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }
 
    }
}