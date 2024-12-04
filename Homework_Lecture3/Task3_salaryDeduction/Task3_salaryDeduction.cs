using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;

namespace Task3_salaryDeduction
{
    internal class Task3_salaryDeduction
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int tabsNum;
            bool isInt;
            isInt = int.TryParse(input, out tabsNum);
            input = Console.ReadLine();
            bool isDouble;
            double salary;
            isDouble = double.TryParse(input, out salary);

            

            for (int i = 0; i < tabsNum; i++)
            {
                string sites = Console.ReadLine().ToLower();

                if (sites.Equals("facebook"))
                {
                    salary -= 150;
                }
                else if (sites.Equals("instagram"))
                {
                    salary -= 100;
                }
                else if (sites.Equals("reddit"))
                {
                    salary -= 50;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You lost your salary");
                    return;
                }               
                

            }

            int salaryInt = (int)(salary);
            Console.WriteLine(salaryInt);

        }
    }
}
