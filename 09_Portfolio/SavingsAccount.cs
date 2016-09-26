namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        private string name;
        private double value;
        private double interestRate;

        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }

        public SavingsAccount(string name, double value, double interestRate)
        {
            this.name = name;
            this.value = value;
            this.interestRate = interestRate;
        }

        public double GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return "SavingsAccount[value=" + value + ".0,interestRate=" + interestRate.ToString().Replace(',', '.') + "]";
        }

        public void ApplyInterest()
        {
            value *= 1 + (interestRate / 100);
        }
    }
}