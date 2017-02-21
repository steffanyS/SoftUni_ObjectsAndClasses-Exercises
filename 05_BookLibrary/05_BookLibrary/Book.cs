using System;

namespace _05_BookLibrary
{
    class Book
    {
        // title, author, publisher, release date, ISBN-number and price. 

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}

