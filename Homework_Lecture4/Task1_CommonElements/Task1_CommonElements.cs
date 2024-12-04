
namespace Homework_Lecture4
{
    internal class Task1_CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");
            List<string> result = new List<string>();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i].Equals(firstArray[j]))
                    {
                        result.Add(secondArray[i]);
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
