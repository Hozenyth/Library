using Library.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class LoanBooks : BaseEntity
    {
        public int IdUser {  get; private set; }
        public int IdBook { get; private set; }         
        public string BookName { get; private set; }
        public string Isbn { get; private set; }
        public DateTime? LoanDate { get; private set; }
        public DateTime? DeliveryDate  { get; private set; }

        public BookStatusEnum Status { get; private set; }

        public bool IsLate { get; set; }

        public LoanBooks( int idUser,string isbn) 
        { 
            IdUser = idUser;
            Isbn = isbn;
        }

        public void CancelLoan()
        {
            if(Status == BookStatusEnum.Created || Status == BookStatusEnum.Unpublished)
            {
                Status = BookStatusEnum.Canceled;
            }
        }
    }
}
