using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_Application
{
    [Serializable]
    public class Student : INotifyPropertyChanged
    {
        private string _lastName;
        private string _firstName;
        private string _middleName;
        private string _group;
        private Gender _gender;
        private DateTime _birthDate;

        public string LastName
        {
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(); }
        }

        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(); }
        }

        public string MiddleName
        {
            get => _middleName;
            set { _middleName = value; OnPropertyChanged(); }
        }

        public string Group
        {
            get => _group;
            set { _group = value; OnPropertyChanged(); }
        }

        public Gender Gender
        {
            get => _gender;
            set { _gender = value; OnPropertyChanged(); }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set { _birthDate = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, {Group}, {Gender}, {BirthDate:dd.MM.yyyy}";
        }
    }

}