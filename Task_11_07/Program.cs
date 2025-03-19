namespace Task_11_07
{
    internal class Program
    {

    static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Изначальный массив до изменения: " + string.Join(", ", originalArray));

            IncrementArrayElements(ref originalArray);  // Вызов метода, который изменит оригинальный массив

            Console.WriteLine("Изначальный массив после изменения: " + string.Join(", ", originalArray));  // Проверяем оригинальный массив после вызова метода
        }

        static void IncrementArrayElements(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
    }
}
