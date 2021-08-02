using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class AlreadyExistsCustomerException : Exception
    {
        public AlreadyExistsCustomerException(Exception innerException)
            : base("Customer with the same id already exists.", innerException) { }
    }
}
