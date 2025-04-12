namespace Task_20_06
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    namespace TrafficLightSimulation
    {

        class Program
        {
            private static TrafficLightColor currentColor = TrafficLightColor.Red;
            private static bool running = true;

            static void Main(string[] args)
            {
                // Запускаем автоматическое переключение цвета в отдельном потоке
                Task.Run(() => AutomaticSwitching());

                Console.WriteLine("Нажмите любую клавишу для ручного переключения цвета. Для выхода нажмите 'q'.");

                while (running)
                {
                    // Ожидаем ввода ключа
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;

                        // Если нажата 'q', останавливаем программу
                        if (key == ConsoleKey.Q)
                        {
                            running = false;
                        }
                        else
                        {
                            // Переключаем цвет вручную
                            SwitchTrafficLight();
                        }
                    }
                }
            }

            private static void AutomaticSwitching()
            {
                while (running)
                {
                    // Автоматически переключаем цвет каждые 3 секунды
                    Thread.Sleep(3000);
                    SwitchTrafficLight();
                }
            }

            private static void SwitchTrafficLight()
            {
                // Переключаем цвет в следующем порядке: Red -> Green -> Yellow -> Red
                currentColor = currentColor switch
                {
                    TrafficLightColor.Red => TrafficLightColor.Green,
                    TrafficLightColor.Green => TrafficLightColor.Yellow,
                    TrafficLightColor.Yellow => TrafficLightColor.Red,
                    _ => currentColor
                };

                Console.WriteLine($"Текущий цвет светофора: {currentColor}");
            }
        }
    }
}
