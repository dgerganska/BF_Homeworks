namespace Task7_BasicStackOperations
{
    internal class Task7_BasicStackOperations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parameters = input.Split(" ");

            int numberOfElements = int.Parse(parameters[0]);
            int elementsToPop = int.Parse(parameters[1]);
            int elementToLook = int.Parse(parameters[2]);

            string[] elements = Console.ReadLine().Split(" ");
            Stack<int> outcome = new Stack<int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                outcome.Push(int.Parse(elements[i]));
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                outcome.Pop();
            }

            if (outcome.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (outcome.Count == 0)
            {

                Console.WriteLine(0);
            }
            else
            {
                int smallest = outcome.Peek();
                foreach (int number in outcome)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
