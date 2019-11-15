using System;

namespace BankAccount.Entities.Exceptions
{
    class WithDrawException : ApplicationException
    {
        public WithDrawException(string message) : base(message) 
        {
        }
    }
}
