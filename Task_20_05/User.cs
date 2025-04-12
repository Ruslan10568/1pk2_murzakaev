namespace Task_20_05
{
    namespace AuthorizationSystem
    {
        // Класс пользователя
        public class User
        {
            public string Username { get; private set; }
            public AccessLevel Level { get; private set; }

            public User(string username, AccessLevel level)
            {
                Username = username;
                Level = level;
            }

            // Метод проверки прав на удаление поста
            public bool CanDeletePost()
            {
                return Level == AccessLevel.MODERATOR || Level == AccessLevel.ADMIN;
            }
        }
    }
}
