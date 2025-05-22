using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using Microsoft.Win32;

namespace Task_39_02
{
    public partial class MainWindow : Window
    {
        // Используем ObservableCollection вместо List
        private ObservableCollection<string> shoppingItems = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            // Привязываем ListBox к нашей коллекции
            lstItems.ItemsSource = shoppingItems;
        }

        // Добавление нового продукта
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewItem.Text))
            {
                shoppingItems.Add(txtNewItem.Text);
                txtNewItem.Clear();
                txtNewItem.Focus();
            }
            else
            {
                MessageBox.Show("Введите название продукта!", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Удаление выбранного продукта
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstItems.SelectedItem != null)
            {
                shoppingItems.Remove((string)lstItems.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления!", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Сохранение списка в файл
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveDialog.DefaultExt = ".txt";

            if (saveDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveDialog.FileName, shoppingItems);
                    MessageBox.Show("Список успешно сохранен!", "Успех",
                                   MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                                  MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        // Загрузка списка из файла
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openDialog.ShowDialog() == true)
            {
                try
                {
                    string[] items = File.ReadAllLines(openDialog.FileName);
                    shoppingItems.Clear();
                    foreach (string item in items)
                    {
                        shoppingItems.Add(item);
                    }
                    MessageBox.Show("Список успешно загружен!", "Успех",
                                   MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                                  MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}