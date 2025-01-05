namespace Task4
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age must be between 0 and 150.") { }

        public InvalidAgeException(string message) : base(message) { }
    }

    public class AgeValidator
    {
        public static string ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException();
            }

            return "Age is valid";
        }

        public static void Main()
        {
            int[] testAges = { 25, -5, 200, 150, 100 };

            foreach (int age in testAges)
            {
                try
                {
                    Console.WriteLine($"Testing age: {age}");
                    string result = ValidateAge(age);
                    Console.WriteLine(result);
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine(); 
            }
        }
    }
}
