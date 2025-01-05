namespace Task2_MaxSequenceOfEquals
{
    internal class Task2_MaxSequenceOfEquals
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            FindLongestSequence(arr);
        }

        static void FindLongestSequence(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            int maxLength = 1;  // Length of the longest sequence
            int currentLength = 1;  // Length of the current sequence
            int bestStartIndex = 0;  // Starting index of the longest sequence
            int currentStartIndex = 0;  // Starting index of the current sequence

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        bestStartIndex = currentStartIndex;
                    }

                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestStartIndex = currentStartIndex;
            }

            for (int i = bestStartIndex; i < bestStartIndex + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
