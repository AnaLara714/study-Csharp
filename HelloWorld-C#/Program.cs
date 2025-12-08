// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 


namespace Polymorphism
{
    // Classe abstrata que serve como modelo para outras formas
    public abstract class Shape
    {
        // Método virtual que pode ser sobrescrito nas subclasses
        public virtual void Draw()
        {
            // Implementação padrão 
        }
    }

    // Classe Circle herda de Shape
    public class Circle : Shape
    {
        // Sobrescreve o método Draw da classe base com novo comportamento
        public override void Draw()
        {
            // Nova implementação específica para círculo
        }
    }
}
