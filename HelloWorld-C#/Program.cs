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
    // Classe que representa um livro
    public class Book
    {
        // Título do livro
        public string Title { get; set; }

        // Preço do livro
        public float Price { get; set; }
    }

    // Repositório responsável por fornecer a lista de livros
    public class BookRepository
    {
        // Retorna uma coleção de livros
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.NET Step by Step", Price = 5 },
                new Book() { Title = "ASP.NET MVC", Price = 9.99f },
                new Book() { Title = "ASP.NET Web API", Price = 12 },
                new Book() { Title = "C# Advanced Topics", Price = 7 },
                new Book() { Title = "C# Advanced Topics II", Price = 9 },
                new Book() { Title = "C# Advanced Topics III", Price = 15 }
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Obtém a lista de livros do repositório
            var books = new BookRepository().GetBooks();

            // -----------------------------
            // SEM LINQ
            // Filtra manualmente os livros com preço menor que 10
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            // -----------------------------
            // COM LINQ (Where)
            // Filtra os livros com preço menor que 10
            var cheapBooksLinq = books.Where(b => b.Price < 10);

            // -----------------------------
            // LINQ - Extension Methods
            // Filtra, ordena pelo título e seleciona apenas o título
            var cheapBooksMoreMethods =
                books.Where(b => b.Price < 10)   // Filtra pelo preço
                     .OrderBy(b => b.Title)      // Ordena pelo título
                     .Select(b => b.Title);      // Retorna apenas o título

            // -----------------------------
            // LINQ - Query Operators (sintaxe SQL-like)
            var cheaperBooksOperators =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // -----------------------------
            // Busca um único livro pelo título
            // Retorna null se não encontrar
            var bookByTitle = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            // Imprime o título se o livro existir (evita NullReferenceException)
            Console.WriteLine(bookByTitle?.Title);

            // -----------------------------
            // Paginação com LINQ
            // Pula os dois primeiros livros e pega os próximos três
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            // -----------------------------
            // Operações de agregação
            // Maior preço da lista
            var maxPrice = books.Max(b => b.Price);

            // Menor preço da lista
            var minPrice = books.Min(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            // -----------------------------
            // Conta quantos livros existem na coleção
            var count = books.Count();
            Console.WriteLine(count);
        }
    }
}


