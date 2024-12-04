namespace Task5_CountCharsInString
{
    internal class Task5_CountCharsInString
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string input = Console.ReadLine().Trim();
            foreach (char c in input)
            {
                if (c != ' ')
                {

                    if (characters.ContainsKey(c))
                    {
                        characters[c]++;
                    }
                    else
                    {
                        
                        characters[c] = 1;
                    }
                }
                
            }

            foreach (KeyValuePair<char, int> entry in characters)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
