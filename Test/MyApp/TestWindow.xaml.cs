using MyApp.Models;
using MyContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyApp
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private PieChartModel PieChart { get; set; }
        private TestModel Test { get; set; }
        public TestWindow()
        {
            InitializeComponent();                
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PieChart = new PieChartModel();
            Test = new TestModel();
            LabelChange(MainWindow.repository.Verbs.Count());
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Test.Clear();
            PieChart.Clear();
            HiddenElements(Visibility.Hidden);
            int count = 0;
            if (!(CountTextBox.Text == "")
                && int.TryParse(CountTextBox.Text, out count)
                && count != 0
                && count <= int.Parse(MaxCountLabelNumber.Content.ToString()))
            {
                Random rand = new Random();
                while (count != 0)
                {
                    IEnumerable<Verb> searchResult;
                    if ((bool)FirstGroupCheckBox.IsChecked && !(bool)SecondGroupCheckBox.IsChecked)
                    {
                        searchResult = MainWindow.repository.SearchByNumberOfGroup(1).Except(Test.TestList).Where(known => !known.IsKnown);
                    }
                    else if (!(bool)FirstGroupCheckBox.IsChecked && (bool)SecondGroupCheckBox.IsChecked)
                    {
                        searchResult = MainWindow.repository.SearchByNumberOfGroup(2).Except(Test.TestList).Where(known => !known.IsKnown);
                    }
                    else
                    {
                        searchResult = MainWindow.repository.Verbs.Except(Test.TestList);
                    }
                    int index = rand.Next(0, searchResult.Count());
                    Test.TestList.Add(searchResult.ElementAt(index));
                    count--;
                }
                ChangeEnables(false);
                TranslationLabel.Content = Test.GetFirstElement()?.Translation.ToString();
            }
            else
            {
                MessageBox.Show("The number is incorrect!");
                return;
            }
        }
        private void ChangeEnables(bool value)
        {
            FirstGroupCheckBox.IsEnabled = value;
            SecondGroupCheckBox.IsEnabled = value;
            CountTextBox.IsEnabled = value;
            StartButton.IsEnabled = value;
            InfinitiveTextBox.IsEnabled = !value;
            PastSimpleTextBox.IsEnabled = !value;
            PastParticipleTextBox.IsEnabled = !value;
            EnterButton.IsEnabled = !value;
        }
        private void LabelChange(int number)
        {
            MaxCountLabelNumber.Content = number;
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var result = Test.FindByTranslation(TranslationLabel.Content.ToString().ToLower());
            if (Test.FindByAll(
                TranslationLabel.Content.ToString(),
                InfinitiveTextBox.Text,
                PastSimpleTextBox.Text,
                PastParticipleTextBox.Text).FirstOrDefault() is null)
            {
                Test.WontBeCorrectList.Add(new Verb()
                {
                    Translation = TranslationLabel.Content.ToString().ToLower(),
                    Infinitive = InfinitiveTextBox.Text.ToLower(),
                    PastSimple = PastSimpleTextBox.Text.ToLower(),
                    PastParticiple = PastParticipleTextBox.Text.ToLower()
                });
                Test.WillBeCorrectList.Add(result.First());
            }
            Test.TestList.Remove(result.First());
            InfinitiveTextBox.Text = PastSimpleTextBox.Text = PastParticipleTextBox.Text = "";
            if (Test.TestList.Count() == 0)
            {
                CreatePieChart();
                CreateDataGrids();
                ChangeEnables(true);
                HiddenElements(Visibility.Visible);
                MessageBox.Show($"You've been given {int.Parse(CountTextBox.Text) - Test.WillBeCorrectList.Count()} correct answers");
                return;
            }
            TranslationLabel.Content = Test.TestList.First().Translation.ToString();
        }
        private void CreateDataGrids()
        {
            AnswerGrid.ItemsSource = Test.WontBeCorrectList.Join(
                Test.WillBeCorrectList,
                item1 => item1.Translation,
                item2 => item2.Translation,
                (item1, item2) => new
                {
                    Infinitive1 = item1.Infinitive,
                    PastSimple1 = item1.PastSimple,
                    PastParticiple1 = item1.PastParticiple,
                    Infinitive2 = item2.Infinitive,
                    PastSimple2 = item2.PastSimple,
                    PastParticiple2 = item2.PastParticiple
                });
        }
        private void CreatePieChart()
        {
            PieChart.Add("Wrong", Test.WontBeCorrectList.Count);
            PieChart.Add("Right", int.Parse(CountTextBox.Text) - Test.WillBeCorrectList.Count());
            DataPieChart.DataContext = PieChart.PieCollection;
        }
        private void HiddenElements(Visibility visibility)
        {
            GridLabels.Visibility = visibility;
            DataPieChart.Visibility = visibility;
            AnswerGrid.Visibility = visibility;
        }

        private void GroupCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)FirstGroupCheckBox.IsChecked && !(bool)SecondGroupCheckBox.IsChecked)
            {
                LabelChange(MainWindow.repository.SearchByNumberOfGroup(1).Except(Test.TestList).Where(known => !known.IsKnown).Count());
            }
            else if (!(bool)FirstGroupCheckBox.IsChecked && (bool)SecondGroupCheckBox.IsChecked)
            {
                LabelChange(MainWindow.repository.SearchByNumberOfGroup(2).Except(Test.TestList).Where(known => !known.IsKnown).Count());
            }
            else
            {
                LabelChange(MainWindow.repository.Verbs.Count());
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.NumPad4:
                    MoveToUIElement(e, FocusNavigationDirection.Previous);
                    break;
                case Key.NumPad8:
                    MoveToUIElement(e, FocusNavigationDirection.Up);
                    break;
                case Key.NumPad6:
                    MoveToUIElement(e, FocusNavigationDirection.Next);
                    break;
                case Key.NumPad2:
                    MoveToUIElement(e, FocusNavigationDirection.Down);
                    break;
                default:
                    break;
            }
        }
        void MoveToUIElement(KeyEventArgs e, FocusNavigationDirection navigation)
        {
            FocusNavigationDirection focusDirection = navigation;
            TraversalRequest request = new TraversalRequest(focusDirection);
            UIElement elementWithFocus = Keyboard.FocusedElement as UIElement;
            if (elementWithFocus != null)
            {
                if (elementWithFocus.MoveFocus(request)) e.Handled = true;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }
    }
}
