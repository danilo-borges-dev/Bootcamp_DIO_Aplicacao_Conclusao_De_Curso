using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class ToWithDraw
    {
        public static bool ToWithDrawValueInAccountCurrent(ClientAccountCurrent client)
        {
            Console.Write("\nInforme o Valor para Saque: ");
            double value = double.Parse(Console.ReadLine());

            if (client.Balance >= value && value > 0)
            {
                double accountBalance = client.Balance;
                accountBalance -= value;
                client.SetNewBalance(accountBalance);
                Console.WriteLine($"Operação de Saque Realizada com Sucesso!\n" +
                    $"Nome do Cliente: {client.Name}" +
                    $"Valor atualizado na Conta R${client.Balance.ToString("C")}");
                return true;
            }
            Console.WriteLine("Operação Negada.Saldo insuficiente!");
            return false;
        }
    }
}
