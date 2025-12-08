// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 


namespace CSharpFundamentals
{
    class Program
    {
        //public class Person1
        //{
        //  public string FirstName;
        //  public string LastName;

        //  public void Introduce()
        //  {
        //      Console.WriteLine("My name is " + FirstName + " " + LastName);
        //  }
        //}

        //public class Person2 
        //{ 
        //  public string Name;
        //  public void Introduce(string to) 
        //  {
        //      Console.WriteLine("Hi {0}, I am {1}", to, Name);
        //  }
        //}

        public class Point
        {
            public int X;
            public int Y;
            public Point(int x, int y) {
                this.X = x;
                this.Y = y;
            }
            public void Move(int x, int y) {
                this.X = x;
                this.Y = y;
            }

            public void Move(Point newLocation)
            {
                if (newLocation == null) 
                    throw new ArgumentNullException("newLocation");
                Move(newLocation.X, newLocation.Y);
            }


      static void Main(string[] args)
      {
         //var john = new Person1();
         // john.FirstName = "joao";
         // john.LastName = "mesquita";
         // john.Introduce();

         //var person = new Person2();
         //   person.Name = "ana";
         //   person.Introduce("Dennis");


      }
    }
}