namespace week5day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account= new Account();
            account.Amount = 1500;
           float result= account.Deposit(200);
            Console.WriteLine(result);
        }
    }
}