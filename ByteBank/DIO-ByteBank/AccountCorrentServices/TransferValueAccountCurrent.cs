using DataList;
using System;
using System.Collections.Generic;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class TransferValueAccountCurrent
    {
        private static List<ClientAccountCurrent> _clientList = null;
        private static ClientAccountCurrent _clientAccountOrigin = null;
        private static ClientAccountCurrent _clientAccountDestiny = null;
        public static bool TransferValue(int clientOrigin, double value, int clientDestiny)
        {
            // Buscar o ID do Cliente Origem e do Cliente Destino
            _clientList = AccountList.ListAccounts;
            foreach (ClientAccountCurrent client in _clientList)
            {
                if (client.IdSystem == clientOrigin)
                {
                    _clientAccountOrigin = client;
                }
            }

            foreach (ClientAccountCurrent client in _clientList)
            {
                if (client.IdSystem == clientDestiny)
                {
                    _clientAccountDestiny = client;
                }
            }



            if (value > 0 && _clientAccountOrigin.Balance > value)
            {
                // Primeiro abate o valor da transferência na conta do cliente que está realizando a transferência
                double accountBalance = _clientAccountOrigin.Balance;
                accountBalance -= value;
                _clientAccountOrigin.SetNewBalance(accountBalance);

                double accountBalanceClientDestiny = _clientAccountDestiny.Balance;  
                accountBalanceClientDestiny += value;
                _clientAccountDestiny.SetNewBalance(accountBalanceClientDestiny);

                Console.WriteLine($"\n Operação de Transferência Realizada com Sucesso!\n" +
                    $" Nome do Cliente: {_clientAccountOrigin.Name}\n" +
                    $" Valor atualizado na sua Conta R${_clientAccountOrigin.Balance.ToString("C")}\n");
                Console.WriteLine(" Tecle ENTER para continuar.");
                Console.ReadKey();
                return true;
            }
            Console.WriteLine($"\nOperação Negada!" +
                $"Você possui R${_clientAccountOrigin.Balance} em conta.\n");
            return false;
        }
    }
}
