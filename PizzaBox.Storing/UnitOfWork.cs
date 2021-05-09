using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storage
{

    
    // Predefined type 'System.Object' is not defined or imported 
    public class UnitOfWork
    {
        private PizzaBoxContext _context;
        //Changed from readonly because readonly can 
        //only be accessed in the constructor.

        public CrustRepository Crusts {get;}
        public SizeRepository Sizes {get;}

        public ToppingRepository Toppings {get; }

        public UnitOfWork(PizzaBoxContext context)
        {
            _context = context;

            Crusts = new CrustRepository(context);
            Sizes = new SizeRepository(context);
            Toppings = new ToppingRepository(context);
            // Customers = new CustomerRepository(context);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}