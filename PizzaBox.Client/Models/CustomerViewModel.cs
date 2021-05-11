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
    public class CustomerViewModel
    {
        [Required]
        public string CustomerName {get; set;}
      
        [Required]
        public string PhoneNumber {get; set;}
        
        [Required]
        public string Address {get; set;} 

              public override string ToString()
        {
            return $"{CustomerName} {PhoneNumber} {Address}";
        }
    }
}
