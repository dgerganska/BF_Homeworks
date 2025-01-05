namespace Task4_CardsGame
{
    internal class Task4_CardsGame
    {
        static void Main()
        {
            List<int> firstDeck = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            List<int> secondDeck = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstCard = firstDeck[0];
                int secondCard = secondDeck[0];

                if (firstCard > secondCard)
                {

                    firstDeck.Add(firstCard);  
                    firstDeck.Add(secondCard); 
                    secondDeck.RemoveAt(0);    
                    firstDeck.RemoveAt(0);   
                }
                else if (secondCard > firstCard)
                {
                    secondDeck.Add(secondCard);  
                    secondDeck.Add(firstCard);   
                    firstDeck.RemoveAt(0);      
                    secondDeck.RemoveAt(0);    
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }

            if (firstDeck.Count > 0)
            {
                int sum = 0;
                foreach (int card in firstDeck)
                {
                    sum += card;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = 0;
                foreach (int card in secondDeck)
                {
                    sum += card;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
