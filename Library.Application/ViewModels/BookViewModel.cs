using System;

namespace Library.Application.ViewModels
{
    public class BookViewModel
    {
        private DateTime createdAd;

        public BookViewModel(string title, DateTime createdAd, string isbn)
        {
            Title = title;
            this.createdAd = createdAd;
            Isbn = isbn;
        }

        public string Title { get; private set; }
        public string Isbn { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
