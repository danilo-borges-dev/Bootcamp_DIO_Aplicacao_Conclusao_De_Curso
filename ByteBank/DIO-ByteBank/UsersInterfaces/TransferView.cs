using DataList;
using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using DIO_ByteBank.Interfaces;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class TransferView
    {
        private static int _idClientOrigen = 0;
        private static int _idClientDestiny = 0;
        private static double _valueToTransfer = 0;
        public static void Transfer()
        {
            ClientAccountCurrent client = LoggedPerson.GetUser();
            Console.Clear();
            Console.WriteLine("\nTela Inical > Transferência");
            Console.WriteLine("\n+============================================================================+");
            Console.WriteLine("|                    ---   Tranferência de Valor   ---                       |");
            Console.WriteLine("+============================================================================+");
            int numberOfCliets = AccountList.TotalClient;
            if (numberOfCliets <= 1) // Se existe apenas um cliente cadastro será necessário cadastro pelo menos mais um para possibilitar a tranferência
            {
                Console.WriteLine("|                                                                            |");
                Console.WriteLine("| No momento existe apenas [01 - Cliente] cadastro no sistema do Banco.      |");
                Console.WriteLine("|                                                                            |");
                Console.WriteLine("| Para realizar uma transferência você precisa cadastrar um segundo cliente. |");
                Console.WriteLine("|                                                                            |");
                Console.WriteLine("+============================================================================+");
                Console.WriteLine("\n\n  Tecle ENTER para continuar e realizar o Cadastro do segundo Cliente.");
                Console.ReadKey();
                NewClientAccountView.AddNewClientInterfaceView();
            }
            ClientListView.ClientList();
            Console.WriteLine("\n");
            Console.Write(" Informe o Código de Cadastro do Cliente de Origem: \n");
            _idClientOrigen = int.Parse(Console.ReadLine());
            Console.Write(" Informe o Código do Cadastro do Clique de Destino: \n");
            _idClientDestiny = int.Parse(Console.ReadLine());
            Console.Write(" [ATENÇÂO] Informe o Valor para Transferência R$ ");
            _valueToTransfer = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n   ---   Valores para Transferência   ---   ");
            Console.WriteLine($@" Valor R$ {_valueToTransfer}");
            Console.WriteLine("\nTecle ENTER para continuar...");
            Console.ReadKey();

            try
            {
                TransferValueAccountCurrent.TransferValue(_idClientOrigen, _valueToTransfer, _idClientDestiny);
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}
