using DIO_ByteBank.AccountCorrent;
using System.Collections.Generic;

namespace DataList
{
    internal static class AccountList
    {
        static List<ClientAccountCurrent> listAccounts = new List<ClientAccountCurrent>();

        public static bool AddNewClientAccount(AccountType type, string name, double balance, double credit)
        {
            ClientAccountCurrent newClient = new ClientAccountCurrent(type, name, balance, credit);
            listAccounts.Add(newClient);
            return true;
        }
    }
}
