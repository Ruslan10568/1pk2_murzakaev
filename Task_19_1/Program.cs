namespace Task_19_1
{
    internal class Program
    {
 
     
            static void Main()
            {
                Console.WriteLine("Введите строку: ");
                string inputText = Console.ReadLine();

                Console.WriteLine("Введите подстроку для поиска: ");
                string searchString = Console.ReadLine();

                if (inputText.Contains(searchString))
                {
                    Console.WriteLine("Введите подстроку для замены: ");
                    string replaceString = Console.ReadLine();

                    string resultText = inputText.Replace(searchString, replaceString);
                    Console.WriteLine("Результат: " + resultText);
                }
                else
                {
                    Console.WriteLine("Подстрока не найдена.");
                }
            }
        }
    }
