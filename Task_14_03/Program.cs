namespace Task_14_03
{

public class Program
    {
        // Статический метод для вычисления факториала
        public static long Factorial(int number)
        {
            // Проверка на неотрицательное число
            if (number < 0)
            {
                throw new ArgumentException("Факториал может быть вычислен только для неотрицательных чисел.");
            }

            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i; // Умножаем результат на текущее число
            }

            return result;
        }

        // Основная программа для проверки метода
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите неотрицательное целое число: ");
                int input = int.Parse(Console.ReadLine());

                long factorial = Factorial(input);
                Console.WriteLine($"Факториал {input}! = {factorial}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Слишком большое число, чтобы вычислить факториал.");
            }
        }
    }
}
