using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class NullCustomerException : Exception
    {
        public NullCustomerException() : base("The customer is null.") { }
    }
}
