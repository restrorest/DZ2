using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Book
    {
        public Book(string title, string autor, string genre, int year, int pagesCount)
        {
            this.Title = title;
            this.Author = autor;
            this.Genre = genre;
            this.Year = year;
            this.PagesCount = pagesCount;
        }

        public string Title { get; set; }
        public string Author{ get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int PagesCount { get; set; }

    }
}
