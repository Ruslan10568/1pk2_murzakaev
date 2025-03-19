namespace Task_13_02
{
    public class Pet
    {

    // Свойства класса
    public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; } // Возраст в годах
        public double Weight { get; set; } // Вес в кг
        public bool IsHealthy { get; set; } // Состояние здоровья (здоров/нездоров)

        // Конструктор по умолчанию
        public Pet()
        {
            Name = "Unnamed";
            Species = "Unknown";
            Age = 0;
            Weight = 0.0;
            IsHealthy = true;
        }

        // Конструктор с параметрами
        public Pet(string name, string species, int age, double weight, bool isHealthy)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }

        // Конструктор с частичными параметрами
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Age = 0;
            Weight = 0.0;
            IsHealthy = true;
        }

        // Метод для вывода информации о питомце
        public void DisplayInfo()
        {
            System.Console.WriteLine("Кличка: " + Name);
            System.Console.WriteLine("Вид животного: " + Species);
            System.Console.WriteLine("Возраст: " + Age + " лет");
            System.Console.WriteLine("Вес: " + Weight + " кг");
            System.Console.WriteLine("Состояние здоровья: " + (IsHealthy ? "Здоров" : "Нездоров"));
            System.Console.WriteLine();
        }

        // Метод для изменения веса питомца
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            System.Console.WriteLine("Вес питомца " + Name + " изменен на " + Weight + " кг.");
        }

        // Метод для изменения состояния здоровья питомца
        public void ChangeHealthStatus(bool isHealthy)
        {
            IsHealthy = isHealthy;
            System.Console.WriteLine("Состояние здоровья питомца " + Name + " изменено на " + (IsHealthy ? "Здоров" : "Нездоров"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Pet
            Pet pet1 = new Pet("Шарик", "Собака", 7, 11.5, true);
            Pet pet2 = new Pet("Феликс", "Кот", 4, 4.0, false);
            Pet pet3 = new Pet("Мурзик", "Кошка");

            // Вывод информации о питомцах
            pet1.DisplayInfo();
            pet2.DisplayInfo();
            pet3.DisplayInfo();

            // Изменение веса и состояния здоровья
            pet1.ChangeWeight(13.0);
            pet1.ChangeHealthStatus(false);

            pet2.ChangeWeight(4.5);
            pet2.ChangeHealthStatus(true);

            // Вывод обновленной информации
            pet1.DisplayInfo();
            pet2.DisplayInfo();
        }
    }
}

