using DIO_ByteBank.AccountCorrentServices;
using DIO_ByteBank.Interfaces;
using DIO_ByteBank.UsersInterfaces;
using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class Operations
    {
        public static void Accomplish(string option, ClientAccountCurrent client, double value)
        {
            while (option.ToUpper() != "X")
            {
                switch (option)
                {
                    case "5":
                        //listar Contas()
                        break;
                    case "4":
                        NewClientAccountView.AddNewClientInterfaceView(); // Cadastrar novo Cliente
                        break;
                    case "1":
                        // Tranferir()
                        break;
                    case "2":
                        ToWithDraw.ToWithDrawValueInAccountCurrent(client, value);  // Sacar
                        break;
                    case "3":
                        ToDepositValueInCurrentAccount.ToDepositValueInAccountCurrent(client, value);  // Depoistar
                        break;
                    case "6":
                        AdministrativeLoginView.LoginView();
                        break;
                    case "7":
                        // Acessar área de cliente
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
