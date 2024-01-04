namespace Homework7
{
    internal class Class4

    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public double LoanAmount { get; set; }
        public double YearlyInterestRate { get; set; }
        public int NumberOfYears { get; set; }

        public double GetMonthlyPayment()
        {
            double monthlyRate = YearlyInterestRate / 12 / 100;
            int numberOfMonths = NumberOfYears * 12;
            return LoanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -numberOfMonths));
        }


        public void output()
        {
            Console.WriteLine($"Id: {Id}, Name: {FirstName} {LastName}, Monthly Payment: {GetMonthlyPayment()}");
        }
    }
}
