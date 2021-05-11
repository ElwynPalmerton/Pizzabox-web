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
    public class PizzaViewModel 
    {
        public List<APizza> PizzaTypes {get; set;}
        
        public string SelectedPizzaType {get; set;}

        public long orderNumber {get; set;}
        
        public void Load()
        {
            PizzaTypes = new List<APizza>()
            {
                new MeatPizza(){
                    Name="Meat Pizza"
                },
                new VeggiePizza(){
                    Name="Veggie Lovers Pizza"
                },
            };
        }

        public override string ToString()
        {
           return $"SelectedPizzaType";
        }
    }
}
