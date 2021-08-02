using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class CustomerDependencyException : Exception
    {
        public CustomerDependencyException(Exception innerException)
            : base("Service dependency error occurred, contact support.", innerException) { }
    }
}
