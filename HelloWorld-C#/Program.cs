// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Runtime.Intrinsics.X86;
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
          // args => expression
          // number = number*number

         Func<int, int> square = number => number*number;

            Console.WriteLine(square(5));
        }
    }
}

