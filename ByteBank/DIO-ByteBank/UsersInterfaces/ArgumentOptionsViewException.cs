using DIO_ByteBank.Interfaces;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class ArgumentOptionsViewException
    {
        public static void ArgumentExceptionView()
        {
            Console.WriteLine("\nTela Inical > Alerta de Erro");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|         A Opção Digitada Não Existe         |");
            Console.WriteLine("|           |   Tente Novamente  |            |");
            Console.WriteLine("+=============================================+");
            Console.WriteLine("\nTecle Enter para continuar.");
            Console.ReadLine();
        }

        public static void ArgumentExceptionView(string erro)
        {
            Console.WriteLine("\nTela Inical > Alerta de Erro");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|         A Opção Digitada Não Existe         |");
            Console.WriteLine("|           |   Tente Novamente  |            |");
            Console.WriteLine("+=============================================+");
            Console.WriteLine($"\n  FALHA: {erro}");
            Console.WriteLine("\nTecle Enter para continuar.");
            Console.ReadLine();
        }
    }
}
