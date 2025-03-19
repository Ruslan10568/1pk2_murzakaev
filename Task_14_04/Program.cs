namespace Task_14_04
{
    public class User
    {
        // Статическое свойство для хранения текущего пользователя
        public static User CurrentUser { get; private set; }

        // Свойства экземпляра класса User
        public string Name { get; set; }
        public string Email { get; set; }

        // Конструктор класса User
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
            Console.WriteLine($"Текущий пользователь установлен: {user.Name} ({user.Email})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем пользователей
            User user1 = new User("Влад Иванов", "vlad@example.com");
            User user2 = new User("Антон Петров", "anton@example.com");

            // Устанавливаем текущего пользователя
            User.SetCurrentUser(user1);

            // Выводим текущего пользователя
            Console.WriteLine($"Информация о текущем пользователе: {User.CurrentUser.Name}, {User.CurrentUser.Email}");

            // Меняем текущего пользователя
            User.SetCurrentUser(user2);

            // Выводим информацию о новом текущем пользователе
            Console.WriteLine($"Информация о текущем пользователе: {User.CurrentUser.Name}, {User.CurrentUser.Email}");
        }
    }
}
