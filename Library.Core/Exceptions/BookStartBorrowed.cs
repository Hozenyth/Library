using System;

namespace Library.Core.Exceptions
{
    public class BookStartBorrowed : Exception
    {
        public BookStartBorrowed() : base("This book was borrowed")
        { 

        }
                
    }
}
