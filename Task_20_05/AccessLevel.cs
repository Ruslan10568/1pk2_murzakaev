namespace Task_20_05
{
    namespace AuthorizationSystem
    {
        // Перечисление уровней доступа
        public enum AccessLevel
        {
            GUEST,     // только чтение
            USER,      // чтение + комментарии
            MODERATOR, // удаление контента
            ADMIN      // полный доступ
        }
    }
}
