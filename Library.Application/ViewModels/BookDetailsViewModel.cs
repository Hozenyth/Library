using Library.Core.Enum;
using System;

namespace Library.Application.ViewModels
{
    public class BookDetailsViewModel
    {
        private BookStatusEnum statusEnum;

        public int Id { get; set; }
        public string Title { get; set; }        
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }       
        public BookStatusEnum Status { get; set; }
        
        public BookDetailsViewModel(int id, string title, string author, string isbn, int year, BookStatusEnum statusEnum)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            Year = year;
            this.statusEnum = statusEnum;
        }
    }
}
