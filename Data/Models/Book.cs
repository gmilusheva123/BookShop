using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        public int BookID {  get; set; }
        public string Title { get; set; }
        public int GenreID {  get; set; }
        public decimal Price { get; set; }


        public Genre Genre { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
