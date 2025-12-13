// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 

namespace Linq 
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by Step", Price = 5},
                new Book() { Title = "ASP.NET MVC", Price = 9.99f},
                new Book() { Title = "ASP.NET Web API", Price = 12},
                new Book() { Title = "C# Advanced Topics", Price = 7},
                new Book() { Title = "C# Advanced Topics II", Price = 9},
                new Book() { Title = "C# Advanced Topics III", Price = 15}
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // sem o linq 
             var cheapBooks = new List<Book>();
             foreach (var book in books) {
                 if (book.Price < 10)
                     cheapBooks.Add(book);
             }

            // com linq 
            var cheapBooksLinq = books.Where(b => b.Price < 10);


            // linq extension methods
            // com linq ordenar os objetos e selecionar apenas o atributo
            // a ser retornado em cada objeto do arranjo
            var cheapBooksMoreMethods =
                books.Where(b => b.Price < 10)
                                  .OrderBy(b => b.Title)
                                  .Select(b=> b.Title);

           
            // linq query operators
            var cheaperBooksOperators =
                 from b in books
                 where b.Price < 10
                 orderby b.Title
                 select b.Title;

            
            //foreach (var book in cheapBooks)
            //{
            //    //Console.WriteLine(book.Title + ' ' + book.Price);
            //    Console.WriteLine(book);
            //}

            var bookByTitle = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            //var book = books.FirstOrDefault(b => b.Title == "ASP.NET MVC");

            Console.WriteLine(bookByTitle?.Title);

            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var maxPrice = books.Max(b =>  b.Price);
            var minPrice = books.Min(b =>  b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            var count  = books.Count();
            Console.WriteLine(count);
        }
    }
}

