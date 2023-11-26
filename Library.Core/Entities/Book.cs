using Library.Core.Enum;
using System;

namespace Library.Core.Entities
{
    public class Book
    {
       public int Id { get; set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int Year { get; private set; }
        public  int? IdUser { get; private set; }
        public DateTime CreatedAd { get; private set; }
        public DateTime DeliveryAt { get; private set; }
        public DateTime StartedAt { get; private set; }      
        public BookStatusEnum Status { get; private set; }

        public Book(string title, string author, string isbn, int year )
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Year = year;
            
            CreatedAd = DateTime.Now;
            
        }

        public void Cancel()
        {
            if (Status == BookStatusEnum.Created || Status == BookStatusEnum.Unpublished)            
                Status = BookStatusEnum.Canceled;
            
        }

        public void Finish()
        {
            if(Status == BookStatusEnum.Loan)
            {
                Status = BookStatusEnum.Delivery; 
                DeliveryAt = DateTime.Now;
            }

        }

        public void Start()
        {
            if( Status == BookStatusEnum.Available || Status == BookStatusEnum.Created ) 
            { 
                Status = BookStatusEnum.Loan; 
                StartedAt = DateTime.Now;
            }

        }

        public void Update( string title, string author)
        {
            Title = title;
            Author = author;
        }

    }
}
