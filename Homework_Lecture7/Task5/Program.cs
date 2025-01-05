namespace Task5
{
    public class FileReader
    {
        public static void ReadFile(string filePath)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(filePath);

                string content = reader.ReadToEnd();
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: The file at '{filePath}' was not found. {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: An I/O error occurred. {ex.Message}");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File reader closed.");
                }
            }
        }

        public static void Main()
        {
            string validFilePath = @"D:\BF_Homworks repo\BF_Homeworks\Homework_Lecture7\Task5\Test_File_Reading.txt";
            string invalidFilePath = @"D:\BF_Homworks repo\BF_Homworks\Homework_Lecture7\Task5\nonexistentFile.txt";

            Console.WriteLine("Testing with a valid file path:");
            ReadFile(validFilePath);
            Console.WriteLine();

            Console.WriteLine("Testing with an invalid file path:");
            ReadFile(invalidFilePath);
        }
    }
}
