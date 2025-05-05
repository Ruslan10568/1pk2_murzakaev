namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;

        }

        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }

        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

    }
}



