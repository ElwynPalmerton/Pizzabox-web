using PizzaBox.Domain.Abstracts;    //What do the dots mean?
using sc = System.Console;
using System.Text.RegularExpressions;

namespace PizzaBox.Domain.Models

{
    public class Customer : AModel 
    {

        public string Name {get; set;}
        public string Address {get; set;}
        public string PhoneNumber {get; set;}

        public Customer(string name, string address, string phoneNumber)
        {
            // this.GetName();
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public Customer()
        {

        }

        public void GetCustomerInfo()
        {

        }

        public override string ToString()
        {
            return $"{Name} - {Address} -  {PhoneNumber}";
        }  
    }
}

