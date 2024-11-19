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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }


        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int number))
            {
                if (number < 0 || number > 100)
                {
                    ResultLabel.Content = "Число должно быть от 0 до 100.";
                    return;
                }

                string rangeMessage;

                if (number >= 0 && number <= 14)
                {
                    rangeMessage = "[0 - 14]";
                }
                else if (number >= 15 && number <= 35)
                {
                    rangeMessage = "[15 - 35]";
                }
                else if (number >= 36 && number <= 50)
                {
                    rangeMessage = "[36 - 50]";
                }
                else 
                {
                    rangeMessage = "[51 - 100]";
                }

                ResultLabel.Content = $"Число {number} попадает в диапазон {rangeMessage}.";
            }
            else
            {
                ResultLabel.Content = "Введите корректное целое число.";
            }

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
