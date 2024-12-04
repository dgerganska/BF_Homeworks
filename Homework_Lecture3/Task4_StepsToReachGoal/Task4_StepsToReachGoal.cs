namespace Task4_StepsToReachGoal
{
    internal class Task4_StepsToReachGoal
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int goal = 10000;
            int steps = 0;
            int totalSteps = 0;


            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Going home"))
                    {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;

                } else
                {
                    steps = int.Parse(input);
                    totalSteps += steps;
                }

             
                if (input.ToLower().Equals("going home") && goal > 0)
                {
                    Console.WriteLine(String.Format("{0} more steps to reach goal.", (goal - totalSteps)));
                }
                 else if (goal - totalSteps <= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                
            }
        }
    }
}
