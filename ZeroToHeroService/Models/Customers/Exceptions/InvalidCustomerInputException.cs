using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class InvalidCustomerException : Exception
    {
        public InvalidCustomerException(string parameterName, object parameterValue)
            : base($"Invalid Customer, " +
                  $"ParameterName: {parameterName}, " +
                  $"ParameterValue: {parameterValue}.")
        { }
    }
}
