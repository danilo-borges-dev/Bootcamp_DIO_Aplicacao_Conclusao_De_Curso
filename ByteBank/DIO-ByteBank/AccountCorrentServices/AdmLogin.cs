using System;

namespace DIO_ByteBank.AccountCorrentServices
{
    internal static class AdmLogin
    {
        private static string _login = "adm";
        private static string _password = "123";

        public static bool ValidateLogin(string login, string password)
        {           

            if (login == _login && password == _password)
            {                
                return true;
            }            
            return false;
        }
    }
}
