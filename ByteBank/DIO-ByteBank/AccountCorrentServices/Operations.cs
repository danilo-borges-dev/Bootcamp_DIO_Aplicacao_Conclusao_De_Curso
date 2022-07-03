using DataList;
using DIO_ByteBank.Interfaces;
using DIO_ByteBank.UsersInterfaces;
using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class Operation
    {
        public static void Accomplish(string option, ClientAccountCurrent client, double value)
        {
            while (option.ToUpper() != "X")
            {
                switch (option)
                {
                    case "1":
                        //listar Contas()
                        break;
                    case "2":
                        AccountList.AddNewClientAccount(); // Inserir Conta()
                        break;
                    case "3":
                        // Tranferir()
                        break;
                    case "4":
                        ToWithDraw.ToWithDrawValueInAccountCurrent(client, value);  // Sacar
                        break;
                    case "5":
                        ToDepositValueInCurrentAccount.ToDepositValueInAccountCurrent(client, value);  // Depoistar
                        break;
                    case "6":
                        AdministrativeView.Menu();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                InitialInterfaceView.Menu(); // Volta para a tela inicial
            }

            Console.WriteLine("Obrigado por Utilizar Nossos Serviços!");
        }
    }
}
