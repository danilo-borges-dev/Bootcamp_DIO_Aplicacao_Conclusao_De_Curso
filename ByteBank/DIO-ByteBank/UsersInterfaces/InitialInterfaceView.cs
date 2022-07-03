using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.Interfaces
{
    internal static class InitialInterfaceView
    {
        private static ClientAccountCurrent userControl = LoggedPerson.GetUser();

        private static string _userName = userControl.Name.ToString();

        private static int _nCharName = _userName.Length;
        
        public static string Menu()
        {          

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
            string selection = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            Console.Clear();
            return selection;
        }
    }
}
