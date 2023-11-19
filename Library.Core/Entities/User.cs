using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class User : BaseEntity
    {      
        public string FullName { get; set; }    
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime BirthDate { get; private set; }    
        public bool Active { get; set; }
        public List<BorrowedBooks> BorrowedBooks { get; private set; }


        public User( string fullname, string email, string password, DateTime bithday) 
        { 
            FullName = fullname;
            Email = email;  
            Password = password;           
            BirthDate = bithday;
            Active = true;

            CreatedAt = DateTime.Now;
            BorrowedBooks = new List<BorrowedBooks>();

        }
    }
}
