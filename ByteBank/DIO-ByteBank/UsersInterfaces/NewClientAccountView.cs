using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.Interfaces
{
    internal static class NewClientAccountView
    {
        public static void AddNewClientInterfaceView()
        {
            string name = "";
            double balance = 0;
            double credit = 0;
            string sType = "0";
            bool op = true;
            AccountType type;

            Console.WriteLine("\n\n\n             Realize o Cadastro do Seu Cliente no DIO Bank");

            Console.WriteLine("\nInforme o Tipo de Conta");
            Console.WriteLine("\n  1 -  Conta Física");
            Console.WriteLine("\n  1 -  Conta Jurídica");
            sType = Console.ReadLine();
            type = (AccountType)Enum.Parse(typeof(AccountType), sType);
            Console.Clear();


            Console.WriteLine("\nInforme o Nome do Cliente:");
            name = Console.ReadLine().ToUpper();

            do
            {
                Console.WriteLine("\nInforme o Saldo Inicial:");
                if (balance < 0)
                {
                    Console.WriteLine("Valor Indálido! - Tente Novamente!");
                }
                else
                {
                    balance = double.Parse(Console.ReadLine());
                    op = false;
                }

            } while (op);

            op = true;

            do
            {
                Console.WriteLine("\nInforme o Crédito Inicial:");
                if (balance < 0)
                {
                    Console.WriteLine("Valor Indálido! - Tente Novamente!");
                }
                else
                {
                    credit = double.Parse(Console.ReadLine());
                    op = false;
                }

            } while (op);

            AddNewClient.AddClient(type, name, balance, credit);

            Console.WriteLine("\n");
            Console.WriteLine("Cadastro Realizado com Sucesso!");
        }
    }
}
