using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{

    public class VeggiePizza : APizza
    {       
        
        protected override void AddName()
        {
            Name = "Veggie Pizza";
        }
        protected override void AddCrust()
        {
            Crust = new Crust() {};
        }

        protected override void AddSize()
        {
            Size = new Size() {};
        }

        protected override void AddToppings()
        {
            Toppings = new List<Topping>();
        }
    }
}
