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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        public Window1()
        {
            InitializeComponent();
           
        }

        private Dictionary<string, string> translations;
        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string inputWord = InputTextBox.Text.Trim().ToLower();
            string translatedWord;

            switch (inputWord)
            {
                case "солнце":
                    translatedWord = "sun";
                    break;
                case "дождь":
                    translatedWord = "rain";
                    break;
                case "снег":
                    translatedWord = "snow";
                    break;
                case "ветер":
                    translatedWord = "wind";
                    break;
                case "облако":
                    translatedWord = "cloud";
                    break;
                case "температура":
                    translatedWord = "temperature";
                    break;
                case "погода":
                    translatedWord = "weather";
                    break;
                case "ясно":
                    translatedWord = "clear";
                    break;
                case "пасмурно":
                    translatedWord = "overcast";
                    break;
                case "гроза":
                    translatedWord = "thunderstorm";
                    break;
                default:
                    ResultLabel.Content = "Такого слова нет.";
                    return;
            }

            ResultLabel.Content = $"Перевод: {translatedWord}";
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
