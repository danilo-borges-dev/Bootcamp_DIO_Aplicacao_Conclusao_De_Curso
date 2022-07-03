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

            Console.WriteLine("\n\n   Você está Tentando Acessar a Aárea Administrativa - Necessário Realizar o Login de Autorização");
            Console.Write("\n   Informe o Nome de usuário autorizado: ");
            Console.Write("\n   ");
            login = Console.ReadLine();
            Console.Write("\n   Informe a Senha de Autorização: ");
            Console.Write("\n   ");
            password = Console.ReadLine();

            bool res = AdmLogin.ValidateLogin(login, password);

            if (res)
            {
                Console.WriteLine("Login Autorizado");
            }
            else
            {
                Console.WriteLine("Login Não Autorizado. Login ou Senha Incorretos");
            }
        }
    }
}
