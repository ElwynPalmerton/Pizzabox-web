using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storage
{
    public class UnitOfWork
    {
        private PizzaBoxContext _context;
        public CrustRepository Crusts {get;}
        public SizeRepository Sizes {get;}
        public CustomerRepository Customers {get;}
        public ToppingRepository Toppings {get; }
        public PizzaRepository Pizzas {get;}
        public StoreRepository Stores {get;}
        public OrderRepository Orders {get;}

        public UnitOfWork(PizzaBoxContext context)
        {
            _context = context;

            Crusts = new CrustRepository(context);
            Sizes = new SizeRepository(context);
            Toppings = new ToppingRepository(context);
            Customers = new CustomerRepository(context);
            Pizzas = new PizzaRepository(context);
            Stores = new StoreRepository(context);
            Orders = new OrderRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}