using System.Collections;
using System.Collections.Generic;

namespace QueueOperations
{
    class Task8_BasicQueueOperations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parameters = input.Split(" ");

            int numberOfElements = int.Parse(parameters[0]);
            int elementsToDequeue = int.Parse(parameters[1]);
            int elementToLook = int.Parse(parameters[2]);

            string[] elements = Console.ReadLine().Split(" ");
            Queue<int> outcome = new Queue<int> ();

            for (int i = 0; i < numberOfElements; i++)
            {
                outcome.Enqueue (int.Parse(elements[i]));
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                outcome.Dequeue();
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
