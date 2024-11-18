namespace Task5_ValidateAgeInput
{
    internal class Task5_ValidateAgeInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int ageInt;

            bool isValid = int.TryParse(Console.ReadLine(), out ageInt);
            if (!isValid)
            {
                Console.WriteLine("Invalid age entered");
            }

        }
    }
}
