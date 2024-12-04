using System.Runtime.CompilerServices;

namespace Task2_FishingTrip
{
    internal class Task2_FishingTrip
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your budget");
            string budget = Console.ReadLine();
            Console.WriteLine("Enter season");
            string season = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the number of people");
            string people = Console.ReadLine();

            double budgetDouble;
            bool isString = double.TryParse(budget, out budgetDouble);
            int NumberOfPeople = 0;
            isString = int.TryParse(people, out NumberOfPeople);

            double boatPrice = 0;
            if (season.Equals("winter"))
            {
                boatPrice = 2600;
            }
            else if (season.Equals("spring"))
            {
                boatPrice = 3000;
            }
            else if (season.Equals("autumn") || season.Equals("summer"))
            {
                boatPrice = 4200;
            }
            else
            {
                Console.WriteLine("Invalid season");
                return;
            }

            if (NumberOfPeople <= 6)
            {
                boatPrice -= boatPrice * 0.1;
            }
            else if (NumberOfPeople <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;

            }

            if ((NumberOfPeople % 2 == 0) && !season.Equals("autumn"))
            {
                boatPrice -= boatPrice * 0.05;
            }

            if (budgetDouble >= boatPrice)
            {
                Console.WriteLine("You have enough money to rent the boat.");
            }
            else
            {
                {
                    Console.WriteLine($"You do not have enough money to rent the boat, you need another {Math.Abs(boatPrice - budgetDouble):0.##}");
                    Console.WriteLine($"The boat price is {boatPrice}");
                }
            }
        }
    }
}
