using DataList;
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
            AccountType typeAccount;
            int option = 1;
            bool op = true;
            int type;
            bool hide = true;

            Interface();

            while (hide)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Interface();

                        Console.Write("   Pessoa: ");
                        option = int.Parse(Console.ReadLine());
                        if (option == 1 || option == 2)
                        {
                            type = option;
                            hide = false;
                        }
                    } while (hide);
                }
                catch
                {
                    Console.WriteLine("Inválido, tente novamente!");
                    Console.ReadLine(); 

                }
            }
            type = option;
            typeAccount = (AccountType)type;


            Console.WriteLine("\n  Informe o Nome do Cliente:");
            Console.Write("   Nome: ");
            name = Console.ReadLine().ToUpper();

            do
            {
                Console.WriteLine("\n  Informe o Saldo Inicial:");
                Console.Write("   Saldo R$ ");
                if (balance < 0)
                {
                    Console.WriteLine("  Valor Indálido! - Tente Novamente!");
                    Console.Clear();
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
                Console.WriteLine("\n  Informe o Crédito Inicial:");
                Console.Write("   Crédito R$ ");
                if (balance < 0)
                {
                    Console.WriteLine("  Valor Indálido! - Tente Novamente!");
                    Console.Clear();
                }
                else
                {
                    credit = double.Parse(Console.ReadLine());
                    op = false;
                }

            } while (op);

            AddNewClient.AddClient(typeAccount, name, balance, credit);

            Console.WriteLine("\n");
            Console.WriteLine("  Cadastro Realizado com Sucesso!");
            Console.WriteLine("  Tecle ENTER para Continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Interface()
        {
            Console.WriteLine("\nDIO Bank > Cadastro");
            Console.WriteLine("\n+=============================================+");
            Console.WriteLine("|         Realize o Cadastro no DIO Bank      |");
            Console.WriteLine("|=============================================|");
            Console.WriteLine("|                                             |");
            Console.WriteLine("| Informe o Tipo de ConTa                     |");
            Console.WriteLine("|  1 -  Conta Física                          |");
            Console.WriteLine("|  2 -  Conta Jurídica                        |");
            Console.WriteLine("+=============================================+");
            Console.WriteLine("\n");
        }
    }
}
