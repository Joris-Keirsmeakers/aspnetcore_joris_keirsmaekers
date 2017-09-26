using System;
using System.Collections.Generic;

namespace Bibliotheek.Models
{
    public class BookListViewModel
    {
        public List<string> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }
}