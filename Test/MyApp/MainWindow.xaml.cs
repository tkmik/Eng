using MyContext.Context;
using MyContext.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Text;
using System.Reflection;
using Microsoft.Win32;
using System.Data.SqlClient;
using MyApp.Services;

namespace MyApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static VerbRepository repository;
        public MainWindow()
        {
            InitializeComponent();        
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                repository = new VerbRepository();
                await repository.LoadAll();
                VerbGrid.ItemsSource = repository.Verbs;
            }
            catch (SqlException)
            {
                try
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\data.json";
                    string text = File.ReadAllText(path);
                    VerbGrid.ItemsSource = JSONConverter<Verb>.Deserialize(text);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Something has happened with database and data!");
                }
            }
        }

        private async void SaveToDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            repository.Verbs = (ObservableCollection<Verb>)VerbGrid.ItemsSource;
            await repository.SaveToDatabase();
            MessageBox.Show("The Data has been saved!");
        }
        private void LoadFromJsonButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON-files|*.json";
            if ((bool)dialog.ShowDialog())
            {
                string text = File.ReadAllText(dialog.FileName);
                VerbGrid.ItemsSource = repository.LoadFromJsonFile(text);
            }
        }
        private void SaveToJsonButton_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "data";
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON-files|*.json";

            if ((bool)dialog.ShowDialog())
            {                   
                string text = repository.SaveToJsonFile();
                File.WriteAllText(dialog.FileName, text);
                MessageBox.Show($"The Data has been saved in a JSON-file!");
            }           
        }

        private void SearchTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var searchResult = repository.Verbs;
            if (!SearchTextBox.Text.Equals(""))
            {
                searchResult = repository.Search(SearchTextBox.Text);
            }            
            if ((bool)FirstTableCheckBox.IsChecked && (bool)SecondTableCheckBox.IsChecked)
            {
                VerbGrid.ItemsSource = searchResult;
            }
            else if ((bool)FirstTableCheckBox.IsChecked)
            {
                searchResult = repository.SearchByNumberOfGroup(1);
            }
            else if ((bool)SecondTableCheckBox.IsChecked)
            {
                searchResult = repository.SearchByNumberOfGroup(2);
            }
            VerbGrid.ItemsSource = searchResult;
        }
        private void FirstTableCheckBox_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox_TextChanged(sender, null);

        }   
        private void SecondTableCheckBox_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox_TextChanged(sender, null);
        }
        private void TestMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            testWindow.Show();
            testWindow.Owner = this;
            this.Hide();
        }
        private void Window_Closed(object sender, System.EventArgs e)
        {
            App.AppClose();
        }
    }
}
