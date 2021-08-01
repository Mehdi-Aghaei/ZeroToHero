using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial interface  IStorageBroker
    {
        ValueTask<Customer> InsertCustomerAsync(Customer customer);
        IQueryable<Customer> SelectAllCustomers();
        ValueTask<Customer> SelectCustomerByIdAsync(Guid customerId);
        ValueTask<Customer> UpdateCustomerAsync(Customer customer);
        ValueTask<Customer> DeleteCustomerAsync(Customer customer);
    }
}
