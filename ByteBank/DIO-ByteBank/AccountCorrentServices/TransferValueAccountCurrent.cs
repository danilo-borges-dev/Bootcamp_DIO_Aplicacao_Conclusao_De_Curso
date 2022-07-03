using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class TransferValueAccountCurrent
    {
        public static bool TransferValue(ClientAccountCurrent clientRoot, double value, ClientAccountCurrent clientDestiny)
        {
            if (value > 0 && clientRoot.Balance < value)
            {
                // Primeiro abate o valor da transferência na conta do cliente que está realizando a transferência
                double accountBalance = clientRoot.Balance;
                accountBalance -= value;
                clientRoot.SetNewBalance(accountBalance);

                double accountBalanceClientDestiny = clientDestiny.Balance;  
                accountBalanceClientDestiny += value;
                clientRoot.SetNewBalance(accountBalanceClientDestiny);

                Console.WriteLine($"\nOperação de Transferência Realizada com Sucesso!\n" +
                    $"Nome do Cliente: {clientRoot.Name}\n" +
                    $"Valor atualizado na sua Conta R${clientRoot.Balance.ToString("C")}\n");
                return true;
            }
            Console.WriteLine($"\nOperação Negada!" +
                $"Você possui R${clientRoot.Balance} em conta.\n");
            return false;
        }
    }
}
