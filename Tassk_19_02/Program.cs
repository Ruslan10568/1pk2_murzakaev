namespace Tassk_19_02
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите произвольный текст:");
            string inputText = Console.ReadLine();

            // Разделение по пробелам
            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nСлова (по пробелам):");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Разделение по предложениям (используем знаки препинания)
            char[] sentenceEndings = new char[] { '.', '!', '?' };
            string[] sentences = inputText.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nПредложения (по знакам препинания):");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}