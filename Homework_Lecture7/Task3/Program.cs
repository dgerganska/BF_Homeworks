namespace Task3
{
    internal class DivisionCalculator
    {
        private static string PerformDivision(int dividend, int divisor)
        {
            try
            {
                int result = dividend / divisor;
                return $"Result: {result}";
            }
            catch (DivideByZeroException)
            {
                return "Error: Cannot divide by zero.";
            }
            catch (Exception ex)
            {
                return $"An unexpected error occurred: {ex.Message}";
            }
            finally
            {
                Console.WriteLine("Division attempt completed.");
            }
        }

        public static string DivideNumbers(int dividend, int divisor)
        {
            string resultMessage = PerformDivision(dividend, divisor);
            
            return resultMessage;
           
           
        }

        public static void Main()
        {
            // Test cases
            Console.WriteLine(DivideNumbers(10, 2));  // Expected: Result: 5
            Console.WriteLine(DivideNumbers(10, 0));  // Expected: Error: Cannot divide by zero.
            Console.WriteLine(DivideNumbers(10, 3));  // Expected: Result: 3
        }
    }
}

