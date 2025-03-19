namespace Task_11_06
{
    internal class Program
    {
    static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Изначальный массив: " + string.Join(", ", originalArray));

            int[] modifiedArray = IncrementArrayElements(originalArray);  // Создаем новый массив, который будет содержать измененные значения

            Console.WriteLine("Измененный массив: " + string.Join(", ", modifiedArray));

            Console.WriteLine("Изначальный массив после вызова метода: " + string.Join(", ", originalArray)); // Проверяем оригинальный массив снова
        }

        static int[] IncrementArrayElements(int[] arr)
        {
            int[] newArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i] + 1; // Увеличиваем каждый элемент на 1
            }

            return newArray; // Возвращаем новый массив
        }
    }
}

