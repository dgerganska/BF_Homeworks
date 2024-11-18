namespace Homework1
{
    internal class Task1_ConvertAndSumNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer number:");
            int Number1;
            if (!int.TryParse(Console.ReadLine(), out Number1))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("Enter second integer number:");
            int Number2;
            if (!int.TryParse(Console.ReadLine(), out Number2))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int sum = Number1 + Number2;
            Console.WriteLine("The sum of your numbers is " + sum);
        }

    }
}
