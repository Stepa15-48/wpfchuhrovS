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

namespace прак
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private const string SecretPassword = "mypassword"; 
        private const string SecretMessage = "Это ваше секретное сообщение!";

       

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Password;

            if (enteredPassword == SecretPassword)
            {
                ResultLabel.Content = SecretMessage;
            }
            else
            {
                ResultLabel.Content = "Пароль неверный. Попробуйте снова.";
                PasswordBox.Clear(); 
                PasswordBox.Focus(); 


            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
