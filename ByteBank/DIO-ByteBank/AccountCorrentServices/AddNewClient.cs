using DataList;
using DIO_ByteBank.AccountCorrent;

namespace DIO_ByteBank.AccountCorrentServices
{
    internal static class AddNewClient
    {
        public static void AddClient(AccountType type, string name, double balance, double credit)
        {
            AccountList.AddNewClientAccount(type, name, balance, credit);
        }
    }
}
