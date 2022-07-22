using DIO_ByteBank.AccountCorrent;
using DIO_ByteBank.Interfaces;
using DIO_ByteBank.UsersInterfaces;
using System;

namespace DIO_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransferView.Transfer();
            try
            {
                NewClientAccountView.AddNewClientInterfaceView();
                Operations.Accomplish(InitialInterfaceView.Menu());
            }
            catch (NullReferenceException)
            {
                ArgumentOptionsViewException.ArgumentExceptionView();
            }
            catch (ArgumentException)
            {
                ArgumentOptionsViewException.ArgumentExceptionView();
            }
            catch (Exception ex)
            {
                ArgumentOptionsViewException.ArgumentExceptionView();
            }
            InitialInterfaceView.Menu();
        }
    }
}
