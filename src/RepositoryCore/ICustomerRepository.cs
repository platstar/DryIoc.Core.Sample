using System.Collections.Generic;

namespace RepositoryCore
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}