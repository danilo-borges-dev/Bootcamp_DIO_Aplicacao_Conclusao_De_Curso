using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class AdministrativeView
    {
        private static char _selection;

        private static ClientAccountCurrent userControl = LoggedPerson.GetUser();
        private static string _userName = userControl.Name.ToString();
        public static void Menu()
        {
            Console.WriteLine("\nTela Inical > Administrativo");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|   Bem-vindo ao DIO ByteBank Administrativo  |");
            Console.WriteLine("|   Informe a Opção Desejada e Tecle Enter    |");
            Console.WriteLine("+=============================================+");
            Console.WriteLine("|                                             |");
            Console.WriteLine("| Opções                                      |");
            Console.WriteLine("|  5 -  Listar Contas                         |");
            Console.WriteLine("|  4 -  Inserir nova Conta                    |");
            Console.WriteLine("|  7 -  Cliente Área                          |"); // Volta para a área do cliente
            Console.WriteLine("|  S -  Sair                                  |");
            Console.WriteLine("+=============================================+");
            Console.Write("  Usuário Logado: "); Console.Write($"{_userName}");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("\n");
            Console.Write("   Opção: ");


            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                Environment.Exit(0);
            }
            _selection = key.KeyChar;
            Console.WriteLine("\n");
            Console.Clear();
            Operations.Accomplish(_selection);
        }
    }
}
