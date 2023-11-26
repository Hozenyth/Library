using Library.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetBooks( string query);
      
        BookDetailsViewModel GetByIsbn(string isbn);

        int Create(NewBookInputModel inputModel);

        void Update(UpdateBookInputModel inputModel);     
        void Delete(int id);
        void Delivery(int id);
        void LoanStart(int id);              
    }
}
