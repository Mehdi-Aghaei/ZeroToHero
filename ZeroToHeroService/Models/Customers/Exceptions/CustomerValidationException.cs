// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace ZeroToHeroService.Models.Customers.Exceptions
{
    public class CustomerValidationException : Exception
    {
        public CustomerValidationException(Exception innerException)
            : base("Invalid input, contact support.", innerException) { }
    }
}
