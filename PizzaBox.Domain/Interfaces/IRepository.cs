using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{   
    public interface IRepository<T>
    {
        IEnumerable<T> Select(Func<T, bool> filter);

        bool Insert();

        T Update();

        bool Delete();
    }
    
}