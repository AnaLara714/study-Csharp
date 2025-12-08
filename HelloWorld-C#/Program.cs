// See https://aka.ms/new-console-template for more information

using System; // // abriga todas essas classes de utilitários básicos e classes de tipos primitivos;
using System.Collections.Generic; // trabalha com coleções de lista 
using System.Linq; // trabalha com dados e realiza consultas nativas
using System.Text; // trabalha com texto e codificações 
using System.Threading.Tasks; // construir aplicativos multithreading 

namespace Extensibility
{
    // Interface que define um contrato de logger.
    // Qualquer classe que implementar ILogger deve ter LogError e LogInfo.
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    // Implementação de ILogger que escreve mensagens no console.
    public class ConsoleLogger : ILogger
    {
        // Escreve mensagem de erro em vermelho.
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        // Escreve mensagem informativa em verde.
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    // Classe responsável por migrar o banco.
    // Ela recebe um ILogger por injeção de dependência.
    public class DbMigrator
    {
        // Referência ao logger que será usado pela classe.
        private readonly ILogger _logger;

        // Construtor recebe qualquer implementação de ILogger.
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        // Executa o processo de migração e registra mensagens antes e depois.
        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at " + DateTime.Now);

            // Registro de detalhes da migração do banco.
            // (Aqui ficaria o código real da migração.)

            _logger.LogInfo("Migrationg finished at " + DateTime.Now);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cria um migrador usando ConsoleLogger para registrar mensagens.
            var dbMigrator = new DbMigrator(new ConsoleLogger());

            // Inicia o processo de migração.
            dbMigrator.Migrate();
        }
    }
}
