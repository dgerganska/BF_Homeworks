namespace Task3_Train
{
    internal class Task3_Train
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split();
            List<int> wagons = new List<int>();
            foreach (string passenger in firstLine)
            {
                wagons.Add(int.Parse(passenger));
            }

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                if (input.StartsWith("Add"))
                {
                    int passengersToAdd = int.Parse(input.Split()[1]);
                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengers = int.Parse(input);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
