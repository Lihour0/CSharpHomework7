namespace Homework7
{
    class Program
    {
        static int DEBUG = 1;
        static void Main()
        {
            if (DEBUG == 1)
            {
                Class4 test = new Class4();
                List<Class4> Loans = new List<Class4>();
                foreach (var loan in Loans)
                {
                    Console.WriteLine($"Id: {loan.Id}, Name: {loan.FirstName} {loan.LastName}, Monthly Payment: {loan.GetMonthlyPayment()}");
                }
            }
        }
    }
}
