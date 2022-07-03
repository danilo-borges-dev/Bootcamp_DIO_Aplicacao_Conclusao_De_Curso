using DIO_ByteBank.AccountCorrent;

namespace DIO_ByteBank.AccountCorrentServices
{
    internal static class LoggedPerson
    {
        private static ClientAccountCurrent _client;

        public static void SetUser(ClientAccountCurrent client)
        {
            _client = client;
        }

        public static ClientAccountCurrent GetUser()
        {
            return _client;
        }
    }
}
