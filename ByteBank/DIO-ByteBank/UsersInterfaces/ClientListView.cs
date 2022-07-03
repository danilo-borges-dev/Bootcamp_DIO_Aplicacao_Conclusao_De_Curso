using DataList;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class ClientListView
    {
        public static void ClientList()
        {
            Console.WriteLine("\n\n\n   ---   Listagem de Clientes DIO ByteBank   ---\n");
                        
            foreach (var item in AccountList.ListAccounts)
            {
                Console.WriteLine($"Nome do Cliente  : {item.Name}");
                Console.WriteLine($"Saldo da Conta R$: {item.Balance.ToString("C")}");
                Console.WriteLine($"Crédito Total R$ : {item.Credit.ToString("C")}\n\n");
            }

            Console.WriteLine("   ---   Listagem de Clientes DIO ByteBank   ---   ");
        }
    }
}
