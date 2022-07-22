using DataList;
using DIO_ByteBank.Interfaces;
using DIO_ByteBank.UsersInterfaces;
using System;
using System.Collections.Generic;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class TransferValueAccountCurrent
    {
        private static List<ClientAccountCurrent> _clientList = null;
        private static ClientAccountCurrent _clientAccountOrigin = null;
        private static ClientAccountCurrent _clientAccountDestiny = null;
        public static void TransferValue(int clientOrigin, double value, int clientDestiny)
        {
            // Buscar o ID do Cliente Origem e do Cliente Destino
            _clientList = AccountList.ListAccounts;
            foreach (ClientAccountCurrent client in _clientList)
            {
                if (client.IdSystem == clientOrigin)
                {
                    _clientAccountOrigin = client;
                }
                else
                {
                    if (_clientAccountOrigin == null)
                    {
                        string erro = "Código de Cliente Não Localizado.";
                        Console.Clear();
                        ArgumentOptionsViewException.ArgumentExceptionView(erro);
                        Console.Clear();
                        ClientListView.ClientList();
                        TransferView.Transfer();
                    }
                }
            }

            foreach (ClientAccountCurrent client in _clientList)
            {
                if (client.IdSystem == clientDestiny && clientDestiny != clientOrigin)
                {
                    _clientAccountDestiny = client;
                }

            }
            if (_clientAccountDestiny == null)
            {
                string erro = "  Código de Cliente Não Localizado.\n Códigos Origem | Destino Não Podem Ser Iguais.";
                Console.Clear();
                ArgumentOptionsViewException.ArgumentExceptionView(erro);
                Console.Clear();
                ClientListView.ClientList();
                TransferView.Transfer();
            }


            try
            {
                if (value > 0 && _clientAccountOrigin.Balance > value)
                {
                    // Primeiro abate o valor da transferência na conta do cliente que está realizando a transferência
                    double accountBalance = _clientAccountOrigin.Balance;
                    accountBalance -= value;
                    _clientAccountOrigin.SetNewBalance(accountBalance);

                    double accountBalanceClientDestiny = _clientAccountDestiny.Balance;
                    accountBalanceClientDestiny += value;
                    _clientAccountDestiny.SetNewBalance(accountBalanceClientDestiny);

                    Console.Clear();
                    Console.WriteLine($"\n Operação de Transferência Realizada com Sucesso!\n" +
                        $" Nome do Cliente: {_clientAccountOrigin.Name}\n" +
                        $" Valor atualizado na sua Conta R${_clientAccountOrigin.Balance.ToString("C")}\n");
                    Console.WriteLine(" Tecle ENTER para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    InitialInterfaceView.Menu();
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }

            try
            {
                Console.WriteLine($"\nOperação Negada!" +
                    $"Você possui R${_clientAccountOrigin.Balance} em conta.\n");
                InitialInterfaceView.Menu();

            }
            catch (NullReferenceException)
            {
                throw;
            }
        }
    }
}
