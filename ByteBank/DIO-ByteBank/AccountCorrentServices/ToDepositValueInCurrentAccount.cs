using DIO_ByteBank.Interfaces;
using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class ToDepositValueInCurrentAccount
    {
        public static  void ToDepositValueInAccountCurrent(ClientAccountCurrent client)
        {
            Console.Write("\nInforme o Valor para Depósito: ");
            double value = double.Parse(Console.ReadLine());

            if (value > 0)
            {
                double accountBalance = client.Balance;
                accountBalance += value;
                client.SetNewBalance(accountBalance);
                Console.WriteLine("\n\n+===========================================================+");
                Console.WriteLine("| Operação de Depósito Realizado com Sucesso!               |");
                Console.WriteLine("+===========================================================+");
                Console.WriteLine($" Nome do Cliente: {client.Name}");
                Console.WriteLine($" Valor atualizado na Conta R${client.Balance.ToString("C")}");
                Console.WriteLine("+-----------------------------------------------------------+");

                Console.WriteLine("\n Tecle ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                InitialInterfaceView.Menu();
            }
            Console.WriteLine("Operação Negada!");
            Console.WriteLine("Tecle ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
            InitialInterfaceView.Menu();
        }
    }
}
