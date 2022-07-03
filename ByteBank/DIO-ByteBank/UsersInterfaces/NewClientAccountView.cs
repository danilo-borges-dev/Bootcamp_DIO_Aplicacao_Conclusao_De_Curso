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
            Console.WriteLine("\n\n\n             Realize o Cadastro do Seu Cliente no DIO Bank");

            Console.WriteLine("\nInforme o seu nome:");
            name = Console.ReadLine().ToUpper(); 

            Console.WriteLine("\nInforme o Saldo Inicial:");
            balance = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o Crédito Inicial:");
            credit = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Cadastro Realizado com Sucesso!");
    }
}
