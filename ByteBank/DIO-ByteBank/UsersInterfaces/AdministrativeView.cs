using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class AdministrativeView
    {
        public static string Menu()
        {
            Console.WriteLine("\n\n\n             Bem-vindo ao DIO Bank Setor Administrativo");
            Console.WriteLine("    Informe a Opção Desejada e Tecle Enter");

            Console.WriteLine("\nOpções");
            Console.WriteLine("  5 -  Listar Contas");
            Console.WriteLine("  4 -  Inserir nova Conta");
            Console.WriteLine("  7 -  Cliente Área"); // Volta para a área do cliente
            Console.WriteLine("  L -  Limpas Tela");
            Console.WriteLine("  S - Sair");
            Console.WriteLine("\n\n");

            string selection = Console.ReadLine().ToUpper().ToString();
            Console.WriteLine("\n");
            return selection;
        }
    }
}
