using System;
using System.Windows;
using System.Windows.Controls;

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
        private const int MAX_BUTTONS = 1000;

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

            // 💡 Перевірка ліміту перед обробкою
            int count = ((to - from) / step) + 1;
            if (count > MAX_BUTTONS)
            {
                MessageBox.Show($"Занадто багато чисел для обробки ({count}). Максимум: {MAX_BUTTONS}.\n" +
                                $"Зменшіть діапазон або збільшіть крок.");
                return;
            }

            for (int i = from; i <= to; i += step)
            {
                int number = i;
                var (isPrime, explanation) = CheckPrimeWithReason(number);

                var btn = new ExplainedButton
                {
                    Content = number.ToString(),
                    Explanation = explanation,
                    Margin = new Thickness(5),
                    Padding = new Thickness(10, 5, 10, 5),
                    WasClicked = false
                };

                btn.Click += ExplainedButton_Click;

                ButtonsPanel.Children.Add(btn);
            }
        }

        private void ExplainedButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ExplainedButton btn)
            {
                string message;

                if (btn.WasClicked)
                {
                   
                    message = $"Ви вже натискали на цю кнопку.\n{btn.Explanation}";
                }
                else
                {
                  
                    message = btn.Explanation;
                    btn.WasClicked = true;
                }

                MessageBox.Show(message);
            }
        }

        private (bool isPrime, string explanation) CheckPrimeWithReason(int number)
        {
            if (number < 2)
                return (false, $"Число {number} не є простим (менше ніж 2)");

            if (number == 2)
                return (true, $"Число {number} є простим (ділиться лише на 1 і {number})");

            if (number % 2 == 0)
                return (false, $"Число {number} складене, бо ділиться на 2");

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return (false, $"Число {number} складене, бо ділиться на {i}");
            }

            return (true, $"Число {number} є простим, не ділиться ні на яке число, крім 1 і самого себе");
        }
    }
}
