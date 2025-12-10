// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Runtime.Intrinsics.X86;
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 
namespace Generics
{
    // Classe genérica: T é um "tipo genérico" que será definido quando instanciado.
    /* T é um parâmetro de tipo, que só é definido quando você cria o objeto.
    permitem criar uma única classe que funciona para qualquer tipo, sem duplicar código. */
    public class GenericList<T>
    {
        // Método que recebe um valor do tipo T.
        public void Add(T value) { }

        // Indexador que retorna um item do tipo T pelo índice.
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Classe Book normal (sem generics).
    public class Book
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista genérica de inteiros.
            var numbers = new GenericList<int>();
            numbers.Add(10);  // Add recebe int, pois T = int.

            // Cria uma lista genérica de Books.
            var book = new GenericList<Book>();
            book.Add(new Book()); // Add recebe Book, pois T = Book.
        }
    }
}

