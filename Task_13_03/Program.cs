namespace Task_13_03
{
    public class Car
    {
        // Свойства класса
        public string LicensePlate { get; set; } // Номер авто
        public string Brand { get; set; } // Марка
        public string Color { get; set; } // Цвет
        public double CurrentSpeed { get; private set; } // Текущая скорость

        // Конструктор по умолчанию
        public Car()
        {
            LicensePlate = "Unknown";
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0.0;
        }

        // Конструктор с параметрами
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0.0;
        }

        // Конструктор с частичными параметрами для номерного знака и марки
        public Car(string licensePlate, string brand)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = "Unknown";
            CurrentSpeed = 0.0;
        }

        // Метод для симуляции равномерного ускорения
        public void Accelerate(double speedIncrease)
        {
            CurrentSpeed += speedIncrease;
            System.Console.WriteLine($"Автомобиль {Brand} с номером {LicensePlate} разогнался до {CurrentSpeed} км/ч.");
        }

        // Метод для торможения автомобиля
        public void Brake(double speedLimit)
        {
            if (CurrentSpeed > speedLimit)
            {
                CurrentSpeed = 0; // Останавливаем автомобиль, если превышена скорость
                System.Console.WriteLine($"Автомобиль {Brand} с номером {LicensePlate} остановился (с превышением скорости).");
            }
            else
            {
                System.Console.WriteLine($"Автомобиль {Brand} с номером {LicensePlate} тормозит (скорость в пределах нормы).");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Car
            Car car1 = new Car("A777YE", "Toyota", "Red");
            Car car2 = new Car("T555TT", "AUDI", "BLACK");
            Car car3 = new Car("C333FG", "Ford");

            // Симуляция ускорения и торможения
            car1.Accelerate(50);
            car1.Brake(60); // Торможение при превышении скорости

            car2.Accelerate(80);
            car2.Brake(70); // Торможение при превышении скорости

            car3.Accelerate(30);
            car3.Brake(40); // Торможение в пределах скорости
        }
    }
}
