using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Input;

namespace WPF_Application
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        private Student _currentStudent;
        private Student _selectedStudent;

        public ObservableCollection<Student> Students
        {
            get => _students;
            set { _students = value; OnPropertyChanged(); }
        }

        public Student CurrentStudent
        {
            get => _currentStudent;
            set { _currentStudent = value; OnPropertyChanged(); }
        }

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set { _selectedStudent = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        private const string DataFileName = "students.dat";

        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>();
            CurrentStudent = new Student
            {
                BirthDate = DateTime.Now,
                Gender = Gender.Мужской
            };

            SaveCommand = new RelayCommand(SaveStudent);
            DeleteCommand = new RelayCommand(DeleteStudent, CanDeleteStudent);

            LoadStudents();
        }

        private void SaveStudent(object parameter)
        {
            if (string.IsNullOrWhiteSpace(CurrentStudent.LastName) ||
                string.IsNullOrWhiteSpace(CurrentStudent.FirstName) ||
                string.IsNullOrWhiteSpace(CurrentStudent.Group))
            {
                MessageBox.Show("Заполните обязательные поля (Фамилия, Имя, Группа)",
                              "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Students.Add(new Student
            {
                LastName = CurrentStudent.LastName,
                FirstName = CurrentStudent.FirstName,
                MiddleName = CurrentStudent.MiddleName,
                Group = CurrentStudent.Group,
                Gender = CurrentStudent.Gender,
                BirthDate = CurrentStudent.BirthDate
            });

            CurrentStudent = new Student
            {
                BirthDate = DateTime.Now,
                Gender = Gender.Мужской
            };

            SaveStudents();
        }

        private bool CanDeleteStudent(object parameter)
        {
            return SelectedStudent != null;
        }

        private void DeleteStudent(object parameter)
        {
            if (SelectedStudent != null)
            {
                Students.Remove(SelectedStudent);
                SaveStudents();
            }
        }

        private void LoadStudents()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(DataFileName, FileMode.Open))
                    {
                        var loadedStudents = (List<Student>)formatter.Deserialize(fs);
                        Students = new ObservableCollection<Student>(loadedStudents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}",
                                  "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveStudents()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(DataFileName, FileMode.Create))
                {
                    formatter.Serialize(fs, Students.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}",
                               "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}