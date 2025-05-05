namespace Task_32_01
{
    public abstract class Obstacles
    {
        public string Name { get; } //название препятствия
                                    //конструктор
        protected Obstacles(string name)
        {
            Name = name;
        }

        public abstract bool CanStop(Kolobok kolobok);
    }
    public class Stone : Obstacles
    {
        public Stone() : base("Камень") { }
        public override bool CanStop(Kolobok kolobok)
        {
            return false; // камень не смог остановить Колобка
        }
    }
}



