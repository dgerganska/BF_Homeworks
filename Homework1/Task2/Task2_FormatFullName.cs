namespace Task2_Format_Full_Name
{
    internal class Task2_FormatFullName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Enter your first name");
            String LastName = Console.ReadLine();

            string Name = string.Concat(LastName + ", " + FirstName);
            Console.WriteLine(Name);
        }
    }
}
