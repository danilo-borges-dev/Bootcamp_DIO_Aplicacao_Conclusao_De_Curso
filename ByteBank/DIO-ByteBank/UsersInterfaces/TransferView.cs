using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class TransferView
    {
        public static void Transfer()
        {
            ClientAccountCurrent client = LoggedPerson.GetUser();

            Console.WriteLine("\n\n\n   ---   Tranferência da Valor   --- ");
        }
    }
}
