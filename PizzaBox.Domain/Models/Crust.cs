using System.Collections.Generic;
using sc = System.Console;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
    public class Crust : Entity
    {

        public string Name {get; set;}

        public ICollection<APizza> Pizzas {get; set;}

        public override string ToString()
        {
            return $"{Name}";
        }

        // sopdfhjds
        //Add these properties to the other components...
    }
}