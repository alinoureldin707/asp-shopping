using _2019_2020.Data;
using System.Collections.Generic;
using System.Linq;

namespace _2019_2020.services
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }
    }
}
