using System.Threading.Tasks.Dataflow;
using static Homework_Lecture5_Methods.Methods;
namespace Homework_Lecture5_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Find the Largest Number in an Array");
                Console.WriteLine("2. Reverse a String");
                Console.WriteLine("3. Generate Fibonacci Sequence");
                Console.WriteLine("4. Check if a Number is Prime");
                Console.WriteLine("5. Sort an Array in Ascending Order");
                Console.WriteLine("6. Swap Two Numbers");
                Console.WriteLine("7. Update Array Elements");
                Console.WriteLine("8. Divide Two Numbers");
                Console.WriteLine("9. Parse String to Number");
                Console.WriteLine("10. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Largest Number: " + Operations.FindLargestNumber());
                        break;
                    case "2":
                        Console.WriteLine("Reversed String: " + Operations.ReverseString());
                        break;
                    case "3":
                        Console.WriteLine("Fibonacci Sequence: " + string.Join(", ", Operations.GenerateFibonacci()));
                        break;
                    case "4":
                        Console.WriteLine(Operations.IsPrime());
                        break;
                    case "5":
                        Operations.SortArrayAscending();
                        break;
                    case "6":
                        Operations.SwapNumbers();
                        break;
                    case "7":
                        Operations.UpdateArrayElements();
                        break;
                    case "8":
                        Operations.DivideNumbers();
                        break;
                    case "9":
                        Console.WriteLine(Operations.ParseStringToInt());
                        break;
                    case "10":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }

                if (choice != "10")
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
