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
        public DbSet<APizza> Pizzas {get; set;}
        public DbSet<AStore> Stores {get; set;}

        public PizzaBoxContext(DbContextOptions options) : base(options)
        {
    
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Toppings
            builder.Entity<Crust>().HasKey(e => e.EntityId);
            builder.Entity<Size>().HasKey(e => e.EntityId);
            builder.Entity<Topping>().HasKey(e => e.EntityId);
            
            //Customers
            builder.Entity<Customer>().HasKey(e => e.EntityId);
            
            //Pizzas
            builder.Entity<APizza>().HasKey(e => e.EntityId);
            builder.Entity<CustomPizza>().HasBaseType<APizza>();
            builder.Entity<MeatPizza>().HasBaseType<APizza>();
            builder.Entity<VeggiePizza>().HasBaseType<APizza>();

            //Stores
            builder.Entity<AStore>().HasKey(e => e.EntityId);
            builder.Entity<ChicagoStore>().HasBaseType<AStore>();
            builder.Entity<NewYorkStore>().HasBaseType<AStore>();
            
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
                },
                new Customer(){
                    EntityId = 2,
                    Name="Dan",
                    PhoneNumber="123-432-2342",
                    Address="123 Street"
                }
            });

            builder.Entity<Size>().HasData(new Size[]{
                new Size() {
                    EntityId = 1, 
                    Name = "Small",
                    Price=5.00M
                },
                new Size() {
                    EntityId = 2, 
                    Name = "Medium",
                    Price=10.00M
                },
                new Size() {
                    EntityId = 3, 
                    Name = "Large",
                    Price=15.00M
                },
            });
            builder.Entity<Crust>().HasData(new Crust[]{
                new Crust() {
                    EntityId=1,
                    Name="Thin",
                    Price=3.00M
                },
                new Crust() {
                    EntityId=2,
                    Name="Thick",
                    Price=4.00M
                },
                new Crust() {
                    EntityId=3,
                    Name="Stuffed",
                    Price=5.00M
                }
            });

            builder.Entity<Topping>().HasData(new Topping[]{
                new Topping(){
                    EntityId=1,
                    Name="Pepperoni",
                    Price=5.00M
                },  
                new Topping(){
                    EntityId=2,
                    Name="Peppers",
                    Price=3.00M
                },
                new Topping(){
                    EntityId=3,
                    Name="Spinach",
                    Price=4.00M
                },  
                new Topping(){
                    EntityId=4,
                    Name="Anchovies",
                    Price=6.00M
                },
                new Topping(){
                    EntityId=5,
                    Name="Pineapple",
                    Price=4.00M
                },  
                new Topping(){
                    EntityId=7,
                    Name="Ham",
                    Price=5.00M
                },  
                new Topping(){
                    EntityId=8,
                    Name="Mushrooms",
                    Price=2.00M
                },  
                new Topping(){
                    EntityId=9,
                    Name="Sausage",
                    Price=4.00M
                },  
            });

            builder.Entity<ChicagoStore>().HasData(new ChicagoStore[]
            {
                new ChicagoStore() {EntityId = 1, Name = "Chitown Main Street"} 
            });

            builder.Entity<NewYorkStore>().HasData(new NewYorkStore[]
            {
                new NewYorkStore() {EntityId = 2, Name= "Big Apple"}
            });





        }
    }
}

