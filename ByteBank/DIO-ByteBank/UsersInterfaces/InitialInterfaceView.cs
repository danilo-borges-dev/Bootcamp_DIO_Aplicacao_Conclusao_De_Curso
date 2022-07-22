using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.Interfaces
{
    internal static class InitialInterfaceView
    {
        private static char _selection;
        private static bool _aproved = true;

        private static ClientAccountCurrent userControl = LoggedPerson.GetUser();
        private static string _userName = userControl.Name.ToString();


        public static object Accomplish { get; private set; }

        public static char Menu()
        {
            _selection = new char();
            Console.WriteLine("\nTela Inical");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|          Bem-vindo ao DIO ByteBank          |");
            Console.WriteLine("|   Informe a Opção Desejada e Tecle Enter    |");
            Console.WriteLine("+=============================================+");
            Console.WriteLine("|                                             |");
            Console.WriteLine("| Opções                                      |");
            Console.WriteLine("|  1 -  Transferir                            |");
            Console.WriteLine("|  2 -  Sacar                                 |");
            Console.WriteLine("|  3 -  Depositar                             |");
            Console.WriteLine("|  6 -  Área Administrativa                   |"); // Somente o usuário adm consegue acessar está área com o usuário e senha
            Console.WriteLine("|  L -  Limpar Tela                           |");
            Console.WriteLine("|  S -  Sair                                  |");
            Console.WriteLine("+=============================================+");
            Console.Write("  Usuário Logado: "); Console.Write($"{_userName}");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("\n");
            Console.Write("   Opção: ");

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.L)
            {
                Console.Clear();
                Menu();
            }

            _selection = key.KeyChar;
            char c = _selection;            

            if (c == 'S')
            {
                Environment.Exit(0);
            }
            do
            {
                if (_selection == '1' || _selection == '2' || _selection == '3' || _selection == '6' || _selection == 'L' || _selection == 'S')
                {
                    Console.WriteLine("\n");
                    Console.Clear();
                    Operations.Accomplish(_selection);
                    _aproved = false;
                }
                else
                {
                    Console.WriteLine("\n\n Opção Inválida - Tente Novamente!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            } while (_aproved);

            return _selection;
        }
    }
}
