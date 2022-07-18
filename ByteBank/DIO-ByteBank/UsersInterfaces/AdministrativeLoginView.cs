using DIO_ByteBank.AccountCorrentServices;
using System;

namespace DIO_ByteBank.UsersInterfaces
{
    internal static class AdministrativeLoginView
    {
        public static object ValidateLogin { get; private set; }

        public static void LoginView()
        {
            string login;
            string password;
            bool res;

            Console.WriteLine("\n\n   Você está Tentando Acessar a Aárea Administrativa");
            Console.WriteLine("  Necessário Realizar o Login de Autorização");
            Console.Write("\n   Informe o Nome de usuário autorizado: ");
            Console.Write("\n   ");
            login = Console.ReadLine();
            Console.Write("\n   Informe a Senha de Autorização: ");
            Console.Write("\n   ");
            password = Console.ReadLine();

            res = AdmLogin.ValidateLogin(login, password);

            do
            {
                if (res)
                {
                    Console.WriteLine("\nLogin Autorizado");
                    Console.WriteLine("Tecle ENTER para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Login Não Autorizado. Login ou Senha Incorretos");
                }
            } while (!res);
            AdministrativeView.Menu();
        }
    }
}
