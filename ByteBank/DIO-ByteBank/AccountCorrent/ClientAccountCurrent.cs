namespace DIO_ByteBank.AccountCorrent
{
    internal class ClientAccountCurrent
    {
        private AccountType AccountType { get; }
        private string _name;
        private string _id;
        private double _balance;
        private double _credit;
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }

        public ClientAccountCurrent(AccountType accountType, string name, string id, double balance, double credit)
        {
            AccountType = accountType;
            _name = name;
            _id = id;
            _balance = balance;
            _credit = credit;
        }

        public void SetNewBalance(double value) => _balance = value;

        public override string ToString()
        {
            string msg = $"\nTipo de Conta: {AccountType}" +
                $"Nome de Cliente: {_name}\n" +
                $"Código: {_id}\n" +
                $"Saldo R$ {_balance}\n" +
                $"Crédito Disponível R$ {_credit}\n";
            return base.ToString();
        }

    }
}
