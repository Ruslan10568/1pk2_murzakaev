namespace Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
                
        }
    }
}
