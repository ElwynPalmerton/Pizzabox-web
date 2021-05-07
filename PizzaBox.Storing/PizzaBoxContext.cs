using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
    public class PizzaBoxContext : DbContext
    {

        public DbSet<Crust> Crusts {get; set;}
        public DbSet<Size> Sizes {get; set;}
        public DbSet<Topping> Toppings {get; set;}
        public PizzaBoxContext(DbContextOptions options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Crust>().HasKey(e => e.EntityId);
            builder.Entity<Size>().HasKey(e => e.EntityId);
            builder.Entity<Topping>().HasKey(e => e.EntityId);
            
            OnModelSeeding(builder);
        }

        private void OnModelSeeding(ModelBuilder builder)
        {

            builder.Entity<Size>().HasData(new Size[]{
                new Size() {EntityId = 1, Name = "Small"},
                new Size() {EntityId = 1, Name = "Medium"},
                new Size() {EntityId = 1, Name = "Large"},
            });
            builder.Entity<Crust>().HasData(new Crust[]{
                new Crust() {
                    EntityId=1,
                    Name="Thin",
                },
                new Crust() {
                    EntityId=1,
                    Name="Medium",
                },
                new Crust() {
                    EntityId=1,
                    Name="Large",
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






//        private readonly IConfiguration _config;
//        public PizzaBoxContext(DbContextOptions options) : base (options)
//        {
//            _config = Configuration.Build();
//        }
//
//        protected override void OnConfiguring(DbContextOptionsBuilder builder)
//        {
//            builder.useSQlServer(_config["secret"]);
//
//        }


//Entity goes in the domain/abstracts.
//
// namespace PizzaBox.Domain.Models
// public absttract class Entity
// {
//     public long EntityId
// }
//Add the "inheritance" tot he domain classes topping, crust, size.