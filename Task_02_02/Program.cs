namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double action_1 = Math.Pow(a - 1, 1.0 / 3.0);
            double action_2 = Math.Pow(b + action_1, 1.0 / 4.0);
            double action_3 = Math.Abs(a - b);
            double action_4 = Math.Sin(Math.Pow(c, 2)) + Math.Tan(c);
            double action_5 = action_3 * action_4;
            double action_6 = action_2 / action_5; //ответ 

            Console.WriteLine(action_6);
        }
    }
}
