namespace Task1_CinemaHall
{
    internal class Task1_cinemaHall
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the type of screening");
            string screening = Console.ReadLine().ToLower();
            if (screening != "premiere" && screening != "normal" && screening != "discount")
            {
                Console.WriteLine("Invalid screening type. Valid types are Premiere, Noormal and Discount.");
                screening = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Enter the number of rows");
            int rows;
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out rows);

            Console.WriteLine("Enter the number of columns");
            input = Console.ReadLine();
            int columns;
            isInt = int.TryParse(input, out columns);

            double price = 0d;

            switch (screening)
            {

                case "premiere":
                    price = 12.00;
                    break;

                case "normal":
                    price = 7.50;
                    break;

                case "discount":
                    price = 5.00;
                    break;

                default:
                    Console.WriteLine("Invalid screening type");
                    break;
            }

            double totalReveneu = price * rows * columns;

            Console.WriteLine(string.Concat("The totalRevenue is ", String.Format("{0:0.##}", totalReveneu)));






        }
    }
}
