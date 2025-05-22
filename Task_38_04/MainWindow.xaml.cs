using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace Task_38_04
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string FilePath = "students_data.xml";

        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
            InitializeControls();
        }

        private void InitializeControls()
        {
            dpBirthDate.SelectedDate = DateTime.Today;
            cmbGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput())
                return;

            var student = CreateStudentFromInput();
            students.Add(student);
            RefreshStudentList();
            ClearFields();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Фамилия обязательна для заполнения!", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Имя обязательно для заполнения!", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                txtFirstName.Focus();
                return false;
            }

            return true;
        }

        private Student CreateStudentFromInput()
        {
            return new Student
            {
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                Group = txtGroup.Text.Trim(),
                Gender = (Gender)Enum.Parse(typeof(Gender),
                         (cmbGender.SelectedItem as ComboBoxItem).Tag.ToString()),
                BirthDate = dpBirthDate.SelectedDate ?? DateTime.Today
            };
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                students.Remove(selectedStudent);
                RefreshStudentList();
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления!", "Информация",
                              MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count > 0)
            {
                var result = MessageBox.Show("Очистить весь список студентов?", "Подтверждение",
                                           MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    students.Clear();
                    RefreshStudentList();
                }
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
            txtLastName.Focus();
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
                    MessageBox.Show($"Ошибка при загрузке данных:\n{ex.Message}", "Ошибка",
                                   MessageBoxButton.OK, MessageBoxImage.Error);
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
                MessageBox.Show($"Ошибка при сохранении данных:\n{ex.Message}", "Ошибка",
                               MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}