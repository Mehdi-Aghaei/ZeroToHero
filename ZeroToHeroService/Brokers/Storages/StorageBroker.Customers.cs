using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        public  DbSet<Customer> Customers { get; set; }

        public async ValueTask<Customer> InsertCustomerAsync(Customer customer)
        {
            EntityEntry<Customer> customerEntityEntry = await this.Customers.AddAsync(customer);
            await this.SaveChangesAsync();

            return customerEntityEntry.Entity;
        }

        public IQueryable<Customer> SelectAllCustomers() => this.Customers.AsQueryable();

        public async ValueTask<Customer> SelectCustomerByIdAsync(Guid customerId)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Customers.FindAsync(customerId);
        }

        public async ValueTask<Customer> UpdateCustomerAsync(Customer customer)
        {
            EntityEntry<Customer> customerEntityEntry = this.Customers.Update(customer);
            await this.SaveChangesAsync();

            return customerEntityEntry.Entity;
        }

        public async ValueTask<Customer> DeleteCustomerAsync(Customer customer)
        {
            EntityEntry<Customer> customerEntityEntry = this.Customers.Remove(customer);
            await this.SaveChangesAsync();

            return customerEntityEntry.Entity;
        }

    }
}
