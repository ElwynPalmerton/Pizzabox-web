using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storage;
using PizzaBox.Storing.Repositories;
using System.Linq;
using System.Text;

namespace PizzaBox.Client.Models
{
    public class StoreViewModel 
    {
        public List<AStore> Stores {get; set;} = new List<AStore>
        {
        };
        
        public string SelectedStore {get; set;}
        
        public void Load(UnitOfWork unitOfWork)
        {
            Stores = unitOfWork.Stores.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        }

        public override string ToString()
        {
           return $"SelectedStore";
        }
    }
}
