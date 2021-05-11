using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Abstracts{

  public abstract class AComponent : Entity
  {
    public string Name {get; set;}
  
    [Column(TypeName = "decimal(4, 2)")]
    public decimal Price {get; set;}

    public override string ToString()
    {
        return $"{Name}";
    }
  
  }
}
