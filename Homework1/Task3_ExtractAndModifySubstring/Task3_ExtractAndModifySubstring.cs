namespace Task3_Extract_And_modify_substring
{
    internal class Task3_ExtractAndModifySubstring
    {
        static void Main(string[] args)
        {
            String sentence = "Make \"sentence\" to upper case";
            Console.WriteLine(sentence);
            Console.WriteLine(sentence.Substring(6, 8).ToUpper());
        }
    }
}
