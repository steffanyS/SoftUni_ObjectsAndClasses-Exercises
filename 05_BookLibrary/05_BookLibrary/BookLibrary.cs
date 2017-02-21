using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books=new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                books.Add(new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = date,
                    ISBN = input[4],
                    Price = decimal.Parse(input[5])
                });
            }

            Dictionary<string, decimal> library=new Dictionary<string,decimal>();

            foreach (var book in books)
            {
                if (!library.ContainsKey(book.Author))
                {
                    library.Add(book.Author,book.Price);
                }
                else
                {
                    library[book.Author] += book.Price;
                }
            }

            var sortedLib = library
                .OrderByDescending(s => s.Value)
                .ThenBy(s=>s.Key);
                

            foreach (var book in library)
            {
                Console.WriteLine("{0} -> {1:f2}",book.Key,book.Value);
            }
        }
    }
}
