using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotheek.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public List<Author> Author { get; set; }
        public string Title { get; set; }
    }
}
