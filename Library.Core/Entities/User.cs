using System;
using System.Collections.Generic;

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
        public List<LoanBooks> LoanBooks { get; private set; }


        public User( string fullname, string email, string password, DateTime bithday) 
        { 
            FullName = fullname;
            Email = email;  
            Password = password;           
            BirthDate = bithday;
            Active = true;

            CreatedAt = DateTime.Now;
            LoanBooks = new List<LoanBooks>();

        }
    }
}
