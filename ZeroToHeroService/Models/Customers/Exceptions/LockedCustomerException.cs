using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class LockedCustomerException : Exception
    {
        public LockedCustomerException(Exception innerException)
            : base("Locked Customer record exception, please try again later.", innerException) { }
    }
}
