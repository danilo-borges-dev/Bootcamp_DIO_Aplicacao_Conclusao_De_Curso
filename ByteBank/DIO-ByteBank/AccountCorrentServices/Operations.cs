using DIO_ByteBank.AccountCorrentServices;
using DIO_ByteBank.Interfaces;
using DIO_ByteBank.UsersInterfaces;
using System;

namespace DIO_ByteBank.AccountCorrent
{
    internal static class Operations
    {
        public static void Accomplish(char option)
        {
            switch (option)
            {
                case '5':
                    ClientListView.ClientList();  // Lista os Clientes do Banco - Somente Login Administrativo possui Acesso
                    AdministrativeView.Menu();
                    break;
                case '4':
                    NewClientAccountView.AddNewClientInterfaceView(); // Cadastrar novo Cliente
                    AdministrativeView.Menu();
                    break;
                case '1':
                    TransferView.Transfer(); // Tranferir valor entre contas
                    break;
                case '2':
                    ToWithDraw.ToWithDrawValueInAccountCurrent(LoggedPerson.GetUser());  // Sacar
                    break;
                case '3':
                    ToDepositValueInCurrentAccount.ToDepositValueInAccountCurrent(LoggedPerson.GetUser());  // Depoistar
                    break;
                case '6':
                    AdministrativeLoginView.LoginView();  // Tela de Login de Usuário Adm
                    break;
                case '7':
                    InitialInterfaceView.Menu();  // Acessar área de cliente
                    break;
                default:
                    throw new ArgumentException();
            }
            Console.WriteLine("Obrigado por Utilizar Nossos Serviços!");
        }
    }
}
