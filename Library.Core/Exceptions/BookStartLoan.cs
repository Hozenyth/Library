using System;

namespace Library.Core.Exceptions
{
    public class BookStartLoan : Exception
    {
        public BookStartLoan() : base("This book was loan")
        { 

        }
                
    }
}
