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
    public class OrderViewModel : IValidatableObject
    {
        public string CustomerName {get; set;}
      
        public List<AStore> Stores {get; set;} = new List<AStore>
        {
        };
        
        public string SelectedStore {get; set;}
        

        [Required]
        public string PhoneNumber {get; set;}
        
        [Required]
        public string Address {get; set;} 

        public List<Crust> Crusts {get; set;} = new List<Crust>
        {
        };
         public List<Size> Sizes {get; set;} = new List<Size>{
        };
        public List<Topping> Toppings {get; set;} = new List<Topping>
        {
      
        };


        [Required(ErrorMessage = "select a crust")]
        public string SelectedCrust {get; set;}
        

        [Required(ErrorMessage = "select size")]
        public string SelectedSize {get; set;}
        
   
        [MinLength(2)]
        public List<string> SelectedToppings {get; set;}
        public void Load(UnitOfWork unitOfWork)
        {   
            Stores = unitOfWork.Stores.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Sizes = unitOfWork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Toppings = unitOfWork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        }

        public string SelectionsToString()
        {
            var sb = new StringBuilder();

            sb.Append(this.SelectedCrust + " ");
            sb.Append(this.SelectedSize + " ");
            foreach (string t in this.SelectedToppings)
            {
                sb.Append(t + " ");
            }

            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (SelectedCrust == SelectedSize)
            {
                yield return new ValidationResult("are you crazy!", new string[] {
                    "SelectedCrust",
                    "SelectedCrustSize"
                });
            }
        }
    }
}
