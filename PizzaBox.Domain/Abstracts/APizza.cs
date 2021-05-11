using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using sc = System.Console;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Abstracts{

    //I don't need this if I'm not using the XML anyway.
    [XmlInclude(typeof(CustomPizza))] 
    // [XmlInclude(typeof(MeatPizza))]
    // [XmlInclude(typeof(VeggiePizza))]

  public abstract class APizza : AModel 
  {
    public string Name;
    public Crust Crust {get; set;}
    public long CrustId {get; set;}
    public Size Size {get; set;}
    public long SizeId {get; set;}
    public List<Topping> Toppings {get; set;}

    [Column(TypeName = "decimal(4, 2)")]
    public decimal Price {get; set;}
    protected APizza()
    {
      Factory();
    }
    protected void Factory()
    {
      AddName();
      AddSize();
      AddCrust();
      AddToppings();
    }

    protected abstract void AddName();
    protected abstract void AddCrust();
    protected abstract void AddSize();
    protected abstract void AddToppings();

    public string MenuToString()
    {
        return $"{Name}";    
    }  

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        var separator = ", ";   

        foreach (var item in Toppings)
        {
          stringBuilder.Append($"{item}{separator}");
        }

        return $"{Name} {Crust}\t\t- {Size} \t\t- {stringBuilder.ToString().TrimEnd(separator.ToCharArray())} - $";    
    }  
  }
}