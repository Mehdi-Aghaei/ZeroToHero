using System;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Brokers;
using ZeroToHeroService.Brokers.DateTimes;
using ZeroToHeroService.Brokers.Storages;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Services.Foundations.Customers
{
    public partial class CustomerService : ICustomerService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;
        private readonly IDateTimeBroker dateTimeBroker;

        public CustomerService(
            IStorageBroker storageBroker, 
            ILoggingBroker loggingBroker,
            IDateTimeBroker dateTimeBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
            this.dateTimeBroker = dateTimeBroker;
        }
        public ValueTask<Customer> ModifyCustomerAsync(Customer customer)=>
        TryCatch(async () =>
        {
            
            ValidateCustomerOnCreate(customer);

            return await this.storageBroker.InsertCustomerAsync(customer);
        });


        public ValueTask<Customer> RegisterCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Customer> RemoveCustomerByIdAsync(Guid customer)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> RetrieveAllStudents()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Customer> RetrieveCustomerByIdAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}