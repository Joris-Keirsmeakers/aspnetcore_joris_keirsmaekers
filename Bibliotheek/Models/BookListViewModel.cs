using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bibliotheek.Models
{
    public class BookListViewModel
    {
        public List<BookDetailViewModel> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }

    public class BookDetailViewModel
    {
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
    }
}