using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.AccountCorrentServices;
using System.Collections.Generic;

namespace DataList
{
    internal static class AccountList
    {
        static List<ClientAccountCurrent> listAccounts = new List<ClientAccountCurrent>();
        private static int _totalClient;

        public static List<ClientAccountCurrent> ListAccounts
        {
            get { return listAccounts; }
        }

        public static int TotalClient
        {
            get { return _totalClient; }
        }

        public static bool AddNewClientAccount(AccountType type, string name, double balance, double credit)
        {
            ClientAccountCurrent newClient = new ClientAccountCurrent(type, name, balance, credit);
            listAccounts.Add(newClient);
            if (AccountList.TotalClient == 0)
            {
                LoggedPerson.SetUser(newClient);
            }
            _totalClient++;
            return true;
        }
    }
}
