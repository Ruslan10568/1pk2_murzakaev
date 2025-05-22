using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace StudentApp
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string FilePath = "students.xml";

        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
            dpBirthDate.SelectedDate = DateTime.Today;
            cmbGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Проверка введенных данных
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Фамилия и имя обязательны для заполнения!");
                return;
            }

            // Создание нового студента
            var student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Group = txtGroup.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender),
                         (cmbGender.SelectedItem as ComboBoxItem).Tag.ToString()),
                BirthDate = dpBirthDate.SelectedDate ?? DateTime.Today
            };

            // Добавление в список
            students.Add(student);

            // Обновление ListBox
            RefreshStudentList();

            // Очистка полей ввода
            ClearFields();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                students.Remove(selectedStudent);
                RefreshStudentList();
            }
        }

        private void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtGroup.Clear();
            cmbGender.SelectedIndex = 0;
            dpBirthDate.SelectedDate = DateTime.Today;
        }

        private void RefreshStudentList()
        {
            lstStudents.ItemsSource = null;
            lstStudents.ItemsSource = students;
        }

        private void LoadStudents()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(List<Student>));
                    using (var reader = new StreamReader(FilePath))
                    {
                        students = (List<Student>)serializer.Deserialize(reader);
                    }
                    RefreshStudentList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Student>));
                using (var writer = new StreamWriter(FilePath))
                {
                    serializer.Serialize(writer, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
    }
}