using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts{

  public abstract class AComponent : Entity
  {
    public string Name {get; set;}
  
    // public decimal Price {get; set;}

    public override string ToString()
    {
        return $"{Name}";
    }
  
  }
}




    // public string MenuString()
    // {
    //   return $"{Name} - ${Price}";
    // }