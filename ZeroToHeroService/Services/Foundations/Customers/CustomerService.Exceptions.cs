using System;
using System.Linq;
using System.Threading.Tasks;
using EFxceptions.Models.Exceptions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ZeroToHeroService.Models.Customers;
using ZeroToHeroService.Models.Customers.Exceptions;

namespace ZeroToHeroService.Services.Foundations.Customers
{
    public partial class CustomerService
    {
        private delegate ValueTask<Customer> ReturningCustomerFunction();
        private delegate IQueryable<Customer> ReturningCustomersFunction();

        private async ValueTask<Customer> TryCatch(ReturningCustomerFunction returningCustomerFunction)
        {
            try
            {
                return await returningCustomerFunction();
            }
            catch (NullCustomerException nullCustomerException)
            {
                throw CreateAndLogValidationException(nullCustomerException);
            }
            catch (InvalidCustomerException invalidCustomerInputException)
            {
                throw CreateAndLogValidationException(invalidCustomerInputException);
            }
            catch (NotFoundCustomerException nullCustomerException)
            {
                throw CreateAndLogValidationException(nullCustomerException);
            }
            catch (SqlException sqlException)
            {
                throw CreateAndLogCriticalDependencyException(sqlException);
            }
            catch (DuplicateKeyException duplicateKeyException)
            {
                var alreadyExistsCustomerException =
                    new AlreadyExistsCustomerException(duplicateKeyException);

                throw CreateAndLogValidationException(alreadyExistsCustomerException);
            }
            catch (DbUpdateConcurrencyException dbUpdateConcurrencyException)
            {
                var lockedCustomerException = new LockedCustomerException(dbUpdateConcurrencyException);

                throw CreateAndLogDependencyException(lockedCustomerException);
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw CreateAndLogDependencyException(dbUpdateException);
            }
            catch (Exception exception)
            {
                throw CreateAndLogServiceException(exception);
            }
        }

        private IQueryable<Customer> TryCatch(ReturningCustomersFunction returningCustomersFunction)
        {
            try
            {
                return returningCustomersFunction();
            }
            catch (SqlException sqlException)
            {
                throw CreateAndLogCriticalDependencyException(sqlException);
            }
            catch (Exception exception)
            {
                throw CreateAndLogServiceException(exception);
            }
        }

        private CustomerServiceException CreateAndLogServiceException(Exception exception)
        {
            var customerServiceException = new CustomerServiceException(exception);
            this.loggingBroker.LogError(customerServiceException);

            return customerServiceException;
        }

        private CustomerDependencyException CreateAndLogDependencyException(Exception exception)
        {
            var customerDependencyException = new CustomerDependencyException(exception);
            this.loggingBroker.LogError(customerDependencyException);

            return customerDependencyException;
        }

        private CustomerDependencyException CreateAndLogCriticalDependencyException(Exception exception)
        {
            var customerDependencyException = new CustomerDependencyException(exception);
            this.loggingBroker.LogCritical(customerDependencyException);

            return customerDependencyException;
        }

        private CustomerValidationException CreateAndLogValidationException(Exception exception)
        {
            var customerValidationException = new CustomerValidationException(exception);
            this.loggingBroker.LogError(customerValidationException);

            return customerValidationException;
        }

    }
}