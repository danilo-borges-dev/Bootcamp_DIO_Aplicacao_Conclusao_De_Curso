using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal class ArgumentOptionsViewException : Exception
    {
        public void ArgumentExceptionView()
        {
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|          A Opção Digitada Não Existe          |");
            Console.WriteLine("|            |   Tente Novamente  |             |");
            Console.WriteLine("+=============================================+");
        }
    }
}
