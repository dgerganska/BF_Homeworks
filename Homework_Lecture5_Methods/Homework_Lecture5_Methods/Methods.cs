using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Homework_Lecture5_Methods
{
    internal class Methods
    {
        // 1. Find the Largest Number in an Array
        public static int FindLargestNumber(int[] input)
        {
            if (input == null || input.Length == 0)
            { 
                throw new ArgumentException("Array cannot be empty."); 
            }
             
            int largest = input[0];

            foreach (int num in input)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        // 2. Reverse a String
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 3. Generate Fibonacci Sequence
        public static int[] GenerateFibonacci(int n)
        {
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

        // 4. Check for Prime Numbers
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        // 5. Sort an Array in Ascending Order
        public static void SortArrayAscending(int[] arr)
        {
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
        }

        // 6. Swap Two Numbers using the ref keyword
        public static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 7. Update Array Elements by multiplying all elements by a given factor
        public static void UpdateArrayElements(ref int[] arr, int factor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= factor;
            }
        }

        // 8. Divide Two Numbers using out keyword
        public static void DivideNumbers(int a, int b, out int quotient, out int remainder)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            quotient = a / b;
            remainder = a % b;
        }

        // 9. Parse String to Number using out keyword
        public static int ParseStringToInt(string str)
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }
            return 0;
        }

        public static string GetValidChoice()
        {
            string choice;

            while (true)
            {
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Allowed choices are: 1, 2, 3, 4, 5, 6.\n");
                }
            }
        }
    }
}
