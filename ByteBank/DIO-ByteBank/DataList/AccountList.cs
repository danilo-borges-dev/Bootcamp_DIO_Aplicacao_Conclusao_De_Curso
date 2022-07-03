using DIO_ByteBank.AccountCorrent;
using System.Collections.Generic;

namespace DataList
{
    internal static class AccountList
    {
        static List<ClientAccountCurrent> listAccounts = new List<ClientAccountCurrent>();

        public static bool AddNewClientAccount(ClientAccountCurrent client)
        {
            listAccounts.Add(client);
            return true;
        }
    }
}
