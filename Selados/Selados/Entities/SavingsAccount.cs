namespace Selados.Entities
{
    sealed class SavingsAccount : Account // A classe está selada!
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // Vou chamar a operação de saque na superclasse (base)
            Balance = Balance - 2.0;
        }

    }
}