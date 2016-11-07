using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryCore
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{ Id =1, FirstName = "Sample" , LastName = "Web.API"},
                new Customer{ Id =2, FirstName = "Sample" , LastName = "Web.MVC"}
            };
            return customers;
        }
    }
}
