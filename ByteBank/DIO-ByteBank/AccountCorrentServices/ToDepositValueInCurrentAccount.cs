using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class ToDepositValueInCurrentAccount
    {
        public static  bool ToDepositValueInAccountCurrent(ClientAccountCurrent client)
        {
            Console.Write("\nInforme o Valor para Saque: ");
            double value = double.Parse(Console.ReadLine());

            if (value > 0)
            {
                double accountBalance = client.Balance;
                accountBalance += value;
                client.SetNewBalance(accountBalance);
                Console.WriteLine($"\nOperação de Depósito Realizado com Sucesso!\n" +
                    $"Nome do Cliente: {client.Name}\n" +
                    $"Valor atualizado na Conta R${client.Balance.ToString("C")}\n");
                return true;
            }
            Console.WriteLine("Operação Negada!");
            return false;
        }
    }
}
