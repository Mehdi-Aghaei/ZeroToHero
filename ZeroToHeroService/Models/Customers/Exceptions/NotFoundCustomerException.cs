using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class NotFoundCustomerException : Exception
    {
        public NotFoundCustomerException(Guid customerId)
            : base($"Couldn't find customer with Id: {customerId}.") { }
    }
}
