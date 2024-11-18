namespace Task4_Calculate_Circle_Area
{
    internal class Task4_CalculateCircleArea
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter length of the radius of a circle");
            double radiusDouble = 0;

            try
            {
                radiusDouble = Double.Parse(Console.ReadLine());
                double area = Math.PI * radiusDouble * radiusDouble;
                Console.WriteLine(string.Concat("The area of the circle is ", String.Format("{0:0.##}", area)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                return;
            }

        }
    }
}
