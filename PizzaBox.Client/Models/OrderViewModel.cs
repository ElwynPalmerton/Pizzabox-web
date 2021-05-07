using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storing.Repositories;
using System.Linq;


namespace PizzaBox.Client.Models
{
    public class OrderViewModel : IValidatableObject
    {
        public List<Crust> Crusts {get; set;} = new List<Crust>
        {
        };
        public List<Size> Sizes {get; set;} = new List<Size>{
        };
        public List<Topping> Toppings {get; set;} = new List<Topping>
        {
      
        };

        [Required(ErrorMessage = "selected crust")]
        // [DataType(DataType.Text)]
        public string SelectedCrust {get; set;}
        [Required(ErrorMessage = "selected size")]
        public string SelectedSize {get; set;}
        
        [Required(ErrorMessage = "selected toppings")]
        // [Range(2, 5)]
        public List<string> SelectedToppings {get; set;}
        
        //Called from the Controller (which has access to unitOfWork)
        public void Load(UnitOfWork unitOfWork)
        {
            Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Sizes = unitOfWork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Toppings = unitOfWork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           //Create instance of collection.
            if (SelectedCrust == SelectedSize)
            {
                yield return new ValidationResult("are you crazy!", new string[] {
                    "SelectedCrust",
                    "SelectedCrustSize"
                });
            }
            // Return instance of collection.
        }
    }
}
