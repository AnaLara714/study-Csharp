// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 

namespace ExecptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara o StreamReader fora do try
            // para que ele possa ser acessado no finally
            StreamReader streamReader = null;

            try
            {
                // Tenta abrir o arquivo no caminho informado
                streamReader = new StreamReader(@"c:\file.zip");

                // Lê todo o conteúdo do arquivo
                var content = streamReader.ReadToEnd();

                // Lança manualmente uma exceção (apenas para exemplo)
                throw new Exception("Oops");
            }
            catch (Exception ex)
            {
                // Captura qualquer exceção ocorrida no bloco try
                // Evita que a aplicação quebre
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                // Sempre é executado, ocorrendo exceção ou não
                // Garante que o recurso seja liberado
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
    }
}

