namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product defaultProduct = new Product();
            Console.WriteLine($"Product: {defaultProduct.Name}, Price: {defaultProduct.Price}, Quantity: {defaultProduct.Quantity}, Total Cost: {defaultProduct.CalculateTotalCost()}");

            Product specificProduct = new Product("Laptop", 999.99m, 5);
            Console.WriteLine($"Product: {specificProduct.Name}, Price: {specificProduct.Price}, Quantity: {specificProduct.Quantity}, Total Cost: {specificProduct.CalculateTotalCost()}");
        }
    }
}
