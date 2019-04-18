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

namespace JobApplicationsTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label usernameLabel = new Label { Content = "Username:", HorizontalContentAlignment = HorizontalAlignment.Center };
            TextBox usernameTextBox = new TextBox { Width = 100, HorizontalAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center };
            Label passwordLabel = new Label { Content = "Password:", HorizontalContentAlignment = HorizontalAlignment.Center };
            PasswordBox passwordTextBox = new PasswordBox { Width = 100, HorizontalAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center, PasswordChar = '*' };
            Button submitButton = new Button { Content = "Submit", Width = 80, Background = new SolidColorBrush(Color.FromRgb(2, 117, 216)) };
            Label notRegisteredLabel = new Label { Content = "Not registered?",
                HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center };
            Button registerButton = new Button { Content = "Register", Width = 80, Background = new SolidColorBrush(Color.FromRgb(2, 117, 216)) };

            Grid.SetRow(usernameLabel, 2);
            Grid.SetColumn(usernameLabel, 1);
            Grid.SetRow(usernameTextBox, 3);
            Grid.SetColumn(usernameTextBox, 1);
            Grid.SetRow(passwordLabel, 5);
            Grid.SetColumn(passwordLabel, 1);
            Grid.SetRow(passwordTextBox, 6);
            Grid.SetColumn(passwordTextBox, 1);
            Grid.SetRow(submitButton, 8);
            Grid.SetColumn(submitButton, 1);
            Grid.SetRow(notRegisteredLabel, 9);
            Grid.SetColumn(notRegisteredLabel, 1);
            Grid.SetRow(registerButton, 10);
            Grid.SetColumn(registerButton, 1);

            MainWindowGrid.Children.Add(usernameLabel);
            MainWindowGrid.Children.Add(usernameTextBox);
            MainWindowGrid.Children.Add(passwordLabel);
            MainWindowGrid.Children.Add(passwordTextBox);
            MainWindowGrid.Children.Add(submitButton);
            MainWindowGrid.Children.Add(notRegisteredLabel);
            MainWindowGrid.Children.Add(registerButton);
        }
    }
}
