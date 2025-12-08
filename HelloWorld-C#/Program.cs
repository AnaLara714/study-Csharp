// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 


namespace Inheritance
{
    class Vehicle
    {
        public string name {  get; set; }
        public string brand { get; set; }

        public void move()
        {
            Console.WriteLine("vehicle in motion.");
        }

        public void stop()
        {
            Console.WriteLine("vehicle in stationary state.");
        }
    }

    class Car:Vehicle { 
        public double speed { get; set; }
        public double distance { get; set; }
        public double Time { get; set; }

        public void calculateSpeed()
        {
            Console.WriteLine("The formular to calculate speed is distance/Time");
        }
    }

    class Engine
    {
        public void start ()
        {
            Console.WriteLine("Engine Started:");
        }
        public void stop() {
            Console.WriteLine("Engine stopped:");
        }
    }

    class Maruti:Car
    {
        // maruti extends Car and thus inherits all methods form Car(except final and static
        // maruti can also define all its specific functionality
        public void MarutiStartDemo()
        {
            Engine MarutiEngine = new Engine();
            MarutiEngine.start();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.name = "Toyota";
            car.move();
      
        }
    }
}