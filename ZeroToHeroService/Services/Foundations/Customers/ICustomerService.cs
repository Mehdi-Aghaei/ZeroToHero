using System;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Services.Foundations.Customers
{
    public interface ICustomerService
    {
        ValueTask<Customer> RegisterCustomerAsync(Customer customer);
        ValueTask<Customer> RetrieveCustomerByIdAsync(Guid customerId);
        ValueTask<Customer> ModifyCustomerAsync(Customer customer);
        ValueTask<Customer> RemoveCustomerByIdAsync(Guid customer);
        IQueryable<Customer> RetrieveAllStudents();
    }
}