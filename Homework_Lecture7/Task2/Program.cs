namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", 1000.00m);

            account.Deposit(500.00m);

            try
            {
                account.Withdraw(300.00m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                account.Withdraw(1500.00m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        
        }
    }
}
