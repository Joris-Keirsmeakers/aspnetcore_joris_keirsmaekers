using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_keirsmaekers_joris.Models
{
    public class BookDetailModel
    {   
        public int id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
