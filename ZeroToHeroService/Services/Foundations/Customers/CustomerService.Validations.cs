using System;
using System.Linq;
using ZeroToHeroService.Models.Customers;
using ZeroToHeroService.Models.Customers.Exceptions;

namespace ZeroToHeroService.Services.Foundations.Customers
{
    public partial class CustomerService
    {
        private static void ValidateCustomerId(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new InvalidCustomerException(
                    parameterName: nameof(Customer.Id),
                    parameterValue: customerId);
            }
        }

        private static void ValidateStorageCustomer(Customer storageCustomer, Guid customerId)
        {
            if (storageCustomer == null)
            {
                throw new NotFoundCustomerException(customerId);
            }
        }

        private void ValidateCustomerOnCreate(Customer customer)
        {
            switch (customer)
            {
                case null:
                    throw new NullCustomerException();

                case { } when IsInvalid(customer.Id):
                    throw new InvalidCustomerException(
                        parameterName: nameof(Customer.Id),
                        parameterValue: customer.Id);
                
            }
        }

        private void ValidateStudentOnModify(Customer customer)
        {
            ValidateCustomer(customer);
            ValidateCustomerStrings(customer);


        }
        

        private static void ValidateCustomerStrings(Customer customer)
        {
            switch (customer)
            {
                case { } when IsInvalid(customer.FirstName):
                    throw new InvalidCustomerException(
                        parameterName: nameof(customer.FirstName),
                        parameterValue: customer.FirstName);
            }
        }



        private bool IsDateNotRecent(DateTimeOffset dateTime)
        {
            DateTimeOffset now = this.dateTimeBroker.GetCurrentDateTime();
            int oneMinute = 1;
            TimeSpan difference = now.Subtract(dateTime);

            return Math.Abs(difference.TotalMinutes) > oneMinute;
        }
        

        private static void ValidateCustomer(Customer customer)
        {
            if (customer is null)
            {
                throw new NullCustomerException();
            }
        }

        private void ValidateStorageCustomers(IQueryable<Customer> storageCustomers)
        {
            if (!storageCustomers.Any())
            {
                this.loggingBroker.LogWarning("No Customers found in storage.");
            }
        }

        private static bool IsNotSame(Guid firstId, Guid secondId) => firstId != secondId;

        private static bool IsNotSame(DateTimeOffset firstDate, DateTimeOffset secondDate) =>
            firstDate != secondDate;

        private static bool IsInvalid(string input) => String.IsNullOrWhiteSpace(input);
        private static bool IsInvalid(Guid input) => input == default;
        private static bool IsInvalid(DateTimeOffset date) => date == default;
        
    }
}