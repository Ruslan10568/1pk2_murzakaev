using System;

namespace Task_38_04
{
    public class Student
    {
        public string LastName { get; set; }     // Фамилия
        public string FirstName { get; set; }    // Имя
        public string MiddleName { get; set; }   // Отчество
        public string Group { get; set; }        // Группа
        public Gender Gender { get; set; }       // Пол
        public DateTime BirthDate { get; set; }  // Дата рождения

        public override string ToString()
        {
            return $"{LastName} {FirstName[0]}. {MiddleName[0]}., {Group}";
        }
    }

    public enum Gender
    {
        Male,       // Мужской
        Female,     // Женский
        Other       // Другой
    }
}