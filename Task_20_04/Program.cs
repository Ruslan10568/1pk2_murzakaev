namespace Task_20_04
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<VehicleType> vehicles = new List<VehicleType>();
            string userInput;

            Console.WriteLine("Введите тип транспортного средства (Car, Bike, Bus, Truck, Motorcycle) для добавления в список, или введите 'exit' для завершения:");

            while (true)
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    break; // Завершение ввода
                }

                // Проверка на наличие типа в перечислении
                if (Enum.IsDefined(typeof(VehicleType), userInput))
                {
                    vehicles.Add((VehicleType)Enum.Parse(typeof(VehicleType), userInput));
                    Console.WriteLine($"{userInput} добавлено в список.");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте еще раз.");
                }
            }

            Console.WriteLine("Введите тип транспортного средства для подсчета (Car, Bike, Bus, Truck, Motorcycle):");
            string countInput = Console.ReadLine();

            if (Enum.IsDefined(typeof(VehicleType), countInput))
            {
                VehicleType countVehicle = (VehicleType)Enum.Parse(typeof(VehicleType), countInput);
                int count = CountVehicles(vehicles, countVehicle);
                Console.WriteLine($"Количество {countVehicle}: {count}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }

        static int CountVehicles(List<VehicleType> vehicles, VehicleType type)
        {
            int count = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle == type)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
