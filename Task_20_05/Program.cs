using Task_20_05.AuthorizationSystem;

namespace Task_20_05
{
    class Program
    {
        static void Main(string[] args)
        {
            User guest = new User("Гость", AccessLevel.GUEST);
            User user = new User("Пользователь", AccessLevel.USER);
            User moderator = new User("Модератор", AccessLevel.MODERATOR);
            User admin = new User("Админ", AccessLevel.ADMIN);

            TryDeletePost(guest);      // Ошибка: Недостаточно прав!
            TryDeletePost(user);       // Ошибка: Недостаточно прав!
            TryDeletePost(moderator);  // Модератор успешно удалил пост.
            TryDeletePost(admin);      // Админ успешно удалил пост.
        }

        // Метод для попытки удаления поста
        static void TryDeletePost(User user)
        {
            if (user.CanDeletePost())
            {
                Console.WriteLine($"{user.Username} успешно удалил пост.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав!");
            }
        }
    }
}
