using System;

public class Student
{
    public string LastName { get; set; }     // Фамилия
    public string FirstName { get; set; }     // Имя
    public string MiddleName { get; set; }    // Отчество
    public string Group { get; set; }         // Группа
    public Gender Gender { get; set; }       // Пол (перечисление)
    public DateTime BirthDate { get; set; }   // Дата рождения
}

public enum Gender
{
    Male,       // Мужской
    Female,     // Женский
    Other       // Другой
}