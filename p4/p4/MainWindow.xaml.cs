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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public enum CorrectAnswer
    {
        Option1,
        Option2,
        Option3
    }

    public class Test
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
    }

    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Password;
            if (validPasswords.Contains(enteredPassword))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль. Пожалуйста, попробуйте еще раз.");
            }
        }
    }

    public partial class MainWindow : Window
    {
        private List<Test> tests = new List<Test>();

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new LoginPage();
        }

        private void ShowEditorPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new EditorPage(tests);
        }

        private void ShowTestPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new TestPage(tests);
        }

        private void ShowNoTestPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new NoTestPage();
        }
    }

    public partial class LoginPage : Page
    {
        private List<string> validPasswords = new List<string> { "пароль1", "пароль2" }; // Пример списка допустимых паролей

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Password;
            if (validPasswords.Contains(enteredPassword))
            {
                NavigationService.Navigate(new EditorPage());
            }
            else
            {
                MessageBox.Show("Неверный пароль. Пожалуйста, попробуйте еще раз.");
            }
        }
    }

    public partial class EditorPage : Page
    {
        private List<Test> tests = new List<Test>();

        public EditorPage(List<Test> tests)
        {
            InitializeComponent();
            TestGrid.ItemsSource = tests;
            this.tests = tests;
        }

        private void AddTestButton_Click(object sender, RoutedEventArgs e)
        {
            tests.Add(new Test());
            TestGrid.Items.Refresh();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения тестов
            MessageBox.Show("Тесты успешно сохранены.");
        }
    }



  

    public partial class TestPage : Page
    {
        private List<Test> tests;
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        public TestPage(List<Test> tests)
        {
            InitializeComponent();
            this.tests = tests;
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < tests.Count)
            {
                Test test = tests[currentQuestionIndex];
                QuestionTextBlock.Text = test.Description;
                Option1RadioButton.Content = test.Option1;
                Option2RadioButton.Content = test.Option2;
                Option3RadioButton.Content = test.Option3;
                Option1RadioButton.IsChecked = Option2RadioButton.IsChecked = Option3RadioButton.IsChecked = false;
            }
            else
            {
                MessageBox.Show($"Тест завершен. Правильные ответы: {correctAnswers}/{tests.Count}");
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Test test = tests[currentQuestionIndex];
            if ((Option1RadioButton.IsChecked == true && test.CorrectAnswer == CorrectAnswer.Option1) ||
                (Option2RadioButton.IsChecked == true && test.CorrectAnswer == CorrectAnswer.Option2) ||
                (Option3RadioButton.IsChecked == true && test.CorrectAnswer == CorrectAnswer.Option3))
            {
                correctAnswers++;
            }
            currentQuestionIndex++;
            LoadQuestion();
        }
    }


    public partial class NoTestPage : Page
    {
        public NoTestPage()
        {
            InitializeComponent();
        }
    }
}


