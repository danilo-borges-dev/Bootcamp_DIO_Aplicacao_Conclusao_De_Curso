using System;

namespace DIO_ByteBank.Interfaces
{
    internal static class InitialInterfaceView
    {
        public static string Menu()
        {
            Console.WriteLine("\n\n\n             Bem-vindo ao DIO Bank");
            Console.WriteLine("    Informe a Opção Desejada e Tecle Enter");

            Console.WriteLine("\nOpções");
            Console.WriteLine("  1 -  Transferir");
            Console.WriteLine("  2 -  Sacar");
            Console.WriteLine("  3 -  Depositar");
            Console.WriteLine("  6 -  Área Administrativa"); // Somente o usuário adm consegue acessar está área com o usuário e senha
            Console.WriteLine("  L -  Limpar Tela");
            Console.WriteLine("  S - Sair");
            Console.WriteLine("\n\n");

            string selection = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            return selection;
        }
    }
}
