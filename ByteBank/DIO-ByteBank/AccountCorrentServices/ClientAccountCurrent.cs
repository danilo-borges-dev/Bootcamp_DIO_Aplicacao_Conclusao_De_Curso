namespace DIO_ByteBank.AccountCorrent
{
    internal class ClientAccountCurrent
    {
        private AccountType AccountType { get; }
        private string _name;
        private double _balance;
        private double _credit;
        private static int _idSystem;
        private int _idClient;
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }

        public double Credit
        {
            get { return _credit;  }
        }

        public ClientAccountCurrent(AccountType accountType, string name, double balance, double credit)
        {
            AccountType = accountType;
            _name = name;
            _balance = balance;
            _credit = credit;
            _idSystem++;
            _idClient = _idSystem;
        }

        public void SetNewBalance(double value) => _balance = value;

        public override string ToString()
        {
            string msg = $"\nTipo de Conta: {AccountType}" +
                $"Nome de Cliente: {_name}\n" +
                $"Código: {_idClient}\n" +
                $"Saldo R$ {_balance}\n" +
                $"Crédito Disponível R$ {_credit}\n";
            return base.ToString();
        }

    }
}
