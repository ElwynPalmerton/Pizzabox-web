using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly PizzaBoxContext _context;

        public OrderRepository(PizzaBoxContext context)
        {
            _context = context;
        }
      
        public IEnumerable<Order> Select(Func<Order, bool> filter)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Order o)
        {
            throw new System.NotImplementedException();
        }

        public Order Update()
        {
            throw new System.NotImplementedException();
        }
    }
}



// Couldn't find an installed template that matches the input, searching online for one that does...
// No templates found matching: 'PizzaBox.Storing/PizzaBox.Storing.csproj'.
// To list installed templates, run 'dotnet new --list'.




// using PizzaBox.Storing.Repository;
// // using PizzaBox.Domain.Models;
// using System.Collections.Generic;
// using PizzaBox.Storing;
// using System.Linq;
// 
// 
// //Add the repositor reference.
// 
// namespace PizzaBox.Storing.Repositories
// {
//     public class OrderRepository : IRepository<Order>
//     {
// 
// 
//         private readonly FileRepository _fileRepository = new FileRepository();
// 
//         private const string _path = @"data/pizzas.xml";
// 
//        public bool Select<Order>()
//         {
//             return true;
//             // throw new System.NotImplementedException();
//         }
//         public bool Create<Order>(Order order)
//         {
//             _fileRepository.WriteToFile<Order>(_path, order);
//            
//             throw new System.NotImplementedException();
//         }
//         public IEnumerable<Order> Read<Order>()
//         {
//             throw new System.NotImplementedException();
//         }
// 
//         public bool Insert<Order>()
//         {
//             throw new System.NotImplementedException();
//         }
// 
//         public Order Update<Order>()
//         {
//             throw new System.NotImplementedException();
//         }
// 
//         public bool Delete<Order>()
//         {
// 
//             throw new System.NotImplementedException();
//         }
//     }
// }

//         public IEnumerable<T> Select();        
//         public bool Create();
//         public IEnumerable<T> Read();
// 
//         public T Update();
// 
//         public bool Delete(); 