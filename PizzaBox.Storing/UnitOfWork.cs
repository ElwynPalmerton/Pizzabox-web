using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storage
{

    
    // Predefined type 'System.Object' is not defined or imported 
    public class UnitOfWork
    {
        private PizzaBoxContext _context;
        public CrustRepository Crusts {get;}
        public SizeRepository Sizes {get;}
        public CustomerRepository Customers {get;}
        public ToppingRepository Toppings {get; }
        public PizzaRepository Pizzas {get;}
        public StoreRepository Stores {get;}

        public UnitOfWork(PizzaBoxContext context)
        {
            _context = context;

            Crusts = new CrustRepository(context);
            Sizes = new SizeRepository(context);
            Toppings = new ToppingRepository(context);
            Customers = new CustomerRepository(context);
            Pizzas = new PizzaRepository(context);
            Stores = new StoreRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}