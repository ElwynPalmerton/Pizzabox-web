// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Web;
// 
// 
// namespace PizzaBox.Client.Models
// {
// 
//     public class SelectedTwoBoxes :ValidationAttribute
//     {
//         protected override ValidationResult IsValid(object value, ValidationContext validationContext)   
//         {
//             var tops = validationContext.ObjectInstance as List<Checkbox>;
// 
//             if (order.SelectedToppings.Count < 2)
//             {   
//                 return new ValidationResult("Select two or more toppings.");
// 
//             }
//             else
//             {
//                 return ValidationResult.Success;
//             }
//         }
//     }
// }
// 
