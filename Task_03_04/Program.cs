namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineCount = 0;
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "exit" || string.IsNullOrEmpty(input))
                {
                    break;
                }

                lineCount++;
                Console.Clear();
            }

            Console.WriteLine($"Количество введенных строк: {lineCount}");
        }
    }
}
