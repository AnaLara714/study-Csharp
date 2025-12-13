// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime? é um tipo anulável (Nullable<DateTime>)
            // Ele pode armazenar um valor DateTime OU null
            DateTime? date = new DateTime(2025, 12, 12);

            // Se 'date' tiver valor, ele é usado.
            // Se 'date' for null, usa DateTime.Today como valor padrão.
            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}



