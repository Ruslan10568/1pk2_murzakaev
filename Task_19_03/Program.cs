namespace Task_19_03
{
    internal class Program
    {
       
    static void Main()
        {
            List<string> lines = new List<string>();
            string inputLine;

            Console.WriteLine("Введите строки (для завершения введите пустую строку):");

            while (true)
            {
                inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    break; 
                }
                lines.Add(inputLine); // Добавляем введенную строку в список
            }

            // Объединение строк с разделителем "-"
            string result = string.Join("-", lines);
            Console.WriteLine("Результат: " + result);
        }
    }
}
