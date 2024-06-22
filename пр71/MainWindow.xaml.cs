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

namespace пр71
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string message;

            if (radioButton.Content.ToString() == "Страдаю трудоголизмом")
            {
                int index = random.Next(3);
                switch (index)
                {
                    case 0:
                        message = "Трудоголизм - это когда ты не можешь остановиться, даже когда уже все сделано.";
                        break;
                    case 1:
                        message = "Трудоголизм - это когда ты не можешь остановиться, потому что ты не знаешь, как остановиться.";
                        break;
                    default:
                        message = "Трудоголизм - это когда ты не можешь остановиться, потому что ты боишься, что если ты остановишься, то все рухнет.";
                        break;
                }
            }
            else
            {
                int index = random.Next(3);
                switch (index)
                {
                    case 0:
                        message = "Отдых - это когда ты можешь ничего не делать и не чувствовать себя виноватым.";
                        break;
                    case 1:
                        message = "Отдых - это когда ты можешь ничего не делать и не чувствовать себя усталым.";
                        break;
                    default:
                        message = "Отдых - это когда ты можешь ничего не делать и не чувствовать себя бесполезным.";
                        break;
                }
            }

            MessageBox.Show(message, "Случайное событие", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
