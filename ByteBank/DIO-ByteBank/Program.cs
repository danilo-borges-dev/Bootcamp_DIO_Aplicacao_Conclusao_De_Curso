using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.Interfaces;

namespace DIO_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClientAccountView.AddNewClientInterfaceView();
            Operations.Accomplish(InitialInterfaceView.Menu());
        }
    }
}
