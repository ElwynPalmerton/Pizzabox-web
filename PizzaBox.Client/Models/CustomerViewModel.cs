using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storing.Repositories;
using System.Linq;
using System.Text;

namespace PizzaBox.Client.Models
{
    public class CustomerViewModel : IValidatableObject
    {
        [Required]
        public string CustomerName {get; set;}
      
        [Required]
        public string PhoneNumber {get; set;}
        
        [Required]
        public string Address {get; set;} 

        // public void Load(UnitOfWork unitOfWork)
        // {
        //     Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        //     Sizes = unitOfWork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        //     Toppings = unitOfWork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        // }

        public string CustomerToString()
        {
            return $"{CustomerName} {PhoneNumber} {Address}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           //Create instance of collection.
            if (false)
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
