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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsPanel.Children.Clear();

            if (!int.TryParse(FromTextBox.Text, out int from) ||
                !int.TryParse(ToTextBox.Text, out int to) ||
                !int.TryParse(StepTextBox.Text, out int step) || step <= 0)
            {
                MessageBox.Show("Введіть правильні числа!");
                return;
            }

            for (int i = from; i <= to; i += step)
            {
                int number = i; // створюємо копію для замикання в лямбді
                var btn = new Button
                {
                    Content = number.ToString(),
                    Margin = new Thickness(5),
                    Padding = new Thickness(10, 5, 10, 5)
                };

                btn.Click += (s, _) =>
                {
                    string result = IsPrime(number) ? "Просте число" : "Складене число";
                    MessageBox.Show($"{number}: {result}");
                };

                ButtonsPanel.Children.Add(btn);
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
