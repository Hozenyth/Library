using Library.Core.Entities;
using System;
using System.Collections.Generic;

namespace Library.Infrastructure.Persistence
{
    public class LibraryDbContext
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<LoanBooks> LoanBooks { get; set; }

        public LibraryDbContext()
        {
            Books = new List<Book>
            {
                new Book( "Short stories in English", "lly Richards", "1529361567", 2019 ),
                new Book( "The Cat in the Hat Comes Back!", "Dr. Seuss", "9780394800028", 1958),
                new Book( "Pride and Prejudice", "Jane Austen", "1840227931", 2019 )
            };

            Users = new List<User>
            {
                new User("Hozenyth Andrade", "hozenyth@email.com.br", "12345", new DateTime(1990,9,6)),
                new User("Alexander Gomes", "alex@email.com.br", "12345", new DateTime(1980,9,6)),
                new User("Marina Andrade", "mari@email.com.br", "12345", new DateTime(2010,2,4))

            };

            LoanBooks = new List<LoanBooks>
            {
                new LoanBooks(2, "1840227931")
            };
        }
    }
}
