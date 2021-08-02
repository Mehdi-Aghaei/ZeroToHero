using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class CustomerServiceException : Exception
    {
        public CustomerServiceException(Exception innerException)
            : base("Service error occurred, contact support.", innerException) { }
    }
}
