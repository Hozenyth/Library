using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Api.Models
{
    public class CreateBookModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Year { get; set; }
    }
}
