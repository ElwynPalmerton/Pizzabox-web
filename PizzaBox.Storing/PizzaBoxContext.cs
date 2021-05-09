using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
    public class PizzaBoxContext : DbContext
    {

        public DbSet<Crust> Crusts {get; set;}
        public DbSet<Size> Sizes {get; set;}
        public DbSet<Topping> Toppings {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public PizzaBoxContext(DbContextOptions options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Crust>().HasKey(e => e.EntityId);
            builder.Entity<Size>().HasKey(e => e.EntityId);
            builder.Entity<Topping>().HasKey(e => e.EntityId);
            builder.Entity<Customer>().HasKey(e => e.EntityId);
            // builder.Entity<APizza>().HasKey(e => e.EntityId);
            
            OnModelSeeding(builder);
        }

        private void OnModelSeeding(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer(){
                    EntityId = 1, 
                    Name = "Uncle John",
                    Address = "100 Uncle John Street",
                    PhoneNumber = "888-888-JOHN"
                }
            });

            builder.Entity<Size>().HasData(new Size[]{
                new Size() {EntityId = 1, Name = "Small"},
                new Size() {EntityId = 2, Name = "Medium"},
                new Size() {EntityId = 3, Name = "Large"},
            });
            builder.Entity<Crust>().HasData(new Crust[]{
                new Crust() {
                    EntityId=1,
                    Name="Thin",
                },
                new Crust() {
                    EntityId=2,
                    Name="Thick",
                },
                new Crust() {
                    EntityId=3,
                    Name="Stuffed",
                }
            });

            builder.Entity<Topping>().HasData(new Topping[]{
                new Topping(){
                    EntityId=1,
                    Name="Pepperoni",
                },  
                new Topping(){
                    EntityId=2,
                    Name="Peppers",
                },
                new Topping(){
                    EntityId=3,
                    Name="Spinach",
                },  
                new Topping(){
                    EntityId=4,
                    Name="Anchovies",
                },
                new Topping(){
                    EntityId=5,
                    Name="Pineapple",
                },  
                new Topping(){
                    EntityId=7,
                    Name="Ham",
                },  
                new Topping(){
                    EntityId=8,
                    Name="Mushrooms",
                },  
                new Topping(){
                    EntityId=9,
                    Name="Sausage",
                },  
             });
        }
    }
}

