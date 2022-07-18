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
                Console.Write($"#{item.IdSystem} - ");
                Console.Write($"Tipo de Conta {item.Account}  |  ");
                Console.Write($"Nome do Cliente  : {item.Name}  |  ");
                Console.Write($"Saldo da Conta R$: {item.Balance.ToString("C")}  |  ");
                Console.Write($"Crédito Total R$ : {item.Credit.ToString("C")}\n");
            }

            Console.WriteLine("   ---   Listagem de Clientes DIO ByteBank   ---   ");
            Console.WriteLine("Tecle ENTER para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
