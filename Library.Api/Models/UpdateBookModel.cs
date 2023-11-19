using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Api.Models
{
    public class UpdateBookModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
    }
}
