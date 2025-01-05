using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lecture5_Methods
{
    internal class Operations
    {
        public static int FindLargestNumber2()
        {
            Console.WriteLine("Enter the integer numbers in the array, separated by spaces:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided. Please enter at least one number.");
                
            }

            string[] inputArray = input.Split(' ');
            int[] arr = Array.ConvertAll(inputArray, int.Parse);

            if (arr.Length == 0)
            {
                Console.WriteLine("No valid numbers provided.");
                return int.MinValue; 
            }

            int largest = arr[0];
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        public static int FindLargestNumber()
        {
            int[] arr;
            while (true) 
            {
                Console.WriteLine("Enter the numbers in the array, separated by spaces:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No input provided. Please enter at least one number.");
                    continue; 
                }

                string[] inputArray = input.Split(' ');

                try
                {
                    arr = Array.ConvertAll(inputArray, int.Parse);
                    if (arr.Length == 0)
                    {
                        Console.WriteLine("No valid numbers provided. Please enter at least one number.");
                        continue; 
                    }
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter only integer numbers.");
                }
            }

            int largest = arr[0];
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        public static string ReverseString()
        {
            Console.WriteLine("Enter a string to reverse:");
            string str = Console.ReadLine();

            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }

        public static int[] GenerateFibonacci()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
                throw new ArgumentException("The number of Fibonacci numbers must be greater than 0.");

            int[] fib = new int[n];
            fib[0] = 0;
            if (n > 1)
                fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib;
        }
         
        public static bool IsPrime()
        {
            Console.WriteLine("Enter a number to check if it's prime:");
            int num = int.Parse(Console.ReadLine());

            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static void SortArrayAscending()
        {
            Console.WriteLine("Enter the numbers to sort, separated by spaces:");
            string[] input = Console.ReadLine().Split(' ', ',');

            int[] arr = Array.ConvertAll(input, int.Parse);

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
        }

        public static void SwapNumbers()
        {
            Console.WriteLine("Enter the first number to swap:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to swap:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Swap: a = " + a + ", b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap: a = " + a + ", b = " + b);
        }

        public static void UpdateArrayElements()
        {
            Console.WriteLine("Enter the numbers to update, separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(input, int.Parse);

            Console.WriteLine("Enter the factor to multiply the array elements by:");
            int factor = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= factor;
            }

            Console.WriteLine("Updated Array: " + string.Join(", ", arr));
        }

        public static void DivideNumbers()
        {
            Console.WriteLine("Enter the numerator:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator:");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("Quotient: " + quotient + ", Remainder: " + remainder);
        }

        public static int ParseStringToInt()
        {
            Console.WriteLine("Enter a string to parse to an integer:");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int result))
            {
                return result;
            }
            return 0;
        }

        
    }
}
