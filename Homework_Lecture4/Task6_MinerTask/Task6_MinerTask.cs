namespace Task6_MinerTask
{
    internal class Task6_MinerTask
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> resources = new Dictionary<string, long>();

            string input = Console.ReadLine().ToLower();

            while (!input.Equals("stop"))
            {
                
                string resource = input;

                string quantityLine = Console.ReadLine();
                if (long.TryParse(quantityLine, out long quantity))
                {
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                    else
                    {
                        resources[resource] = quantity;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid quantity.");
                    return; 
                }
                input = Console.ReadLine().ToLower();
            }

            foreach (KeyValuePair<string, long> resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
