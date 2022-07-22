using DIO_ByteBank.Interfaces;
using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class ToWithDraw
    {
        public static void ToWithDrawValueInAccountCurrent(ClientAccountCurrent client)
        {
            Console.Write("\nInforme o Valor para Saque: ");
            double value = double.Parse(Console.ReadLine());

            if (client.Balance >= value && value > 0)
            {
                double accountBalance = client.Balance;
                accountBalance -= value;
                client.SetNewBalance(accountBalance);
                Console.WriteLine($" Operação de Saque Realizada com Sucesso!\n" +
                    $" Nome do Cliente: {client.Name}\n" +
                    $" Valor atualizado na Conta R${client.Balance.ToString("C")}\n");
                Console.WriteLine(" Tecle ENTER para continuar..");
                Console.ReadKey();
                Console.Clear();
                InitialInterfaceView.Menu();
            }
            Console.WriteLine(" Operação Negada.Saldo insuficiente!");
            Console.WriteLine(" Tecle Enter para continuiar.");
            Console.ReadLine();
            Console.Clear();
            InitialInterfaceView.Menu();
        }
    }
}
