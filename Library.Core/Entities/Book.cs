using Library.Core.Enum;
using System;

namespace Library.Core.Entities
{
    public class Book
    {
       
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int Year { get; private set; }
        public  int? IdUser { get; private set; }
        public DateTime CreatedAd { get; private set; }
        public DateTime? Borrowed{ get; private set; }
        public BookStatusEnum StatusEnum { get; private set; }

        public Book(string title, string author, string isbn, int year )
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Year = year;

            CreatedAd = DateTime.Now;
            
        }
    }
}
