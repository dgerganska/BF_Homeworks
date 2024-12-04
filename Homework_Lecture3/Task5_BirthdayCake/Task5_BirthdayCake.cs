namespace Task5_BirthdayCake
{
    internal class Task5_BirthdayCake
    {
        static void Main(string[] args)
        {
            string[] cakeDimensions = Console.ReadLine().Split();
            int width = int.Parse(cakeDimensions[0]);
            int length = int.Parse(cakeDimensions[1]);

            int totalPieces = width * length;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower().Equals("stop"))
                {
                    if (totalPieces > 0)
                    {
                        Console.WriteLine($"{totalPieces} pieces are left.");
                    }
                    break;
                }
                else
                {
                    int piecesTaken = int.Parse(input);
                    totalPieces -= piecesTaken;

                }                

                if (totalPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
