namespace Herança.Entities
{
    class BusinessAccount : Account // BusinessAccount vai herdar td da classe Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance,double loanLimit) : base(number, holder, balance) //Construtor da subclasse
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance = Balance + amount;
            }
        }
    }
}
