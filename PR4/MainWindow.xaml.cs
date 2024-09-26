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

namespace PR4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(TextBox.Text, out int N))
            {
                ListBoxNumbers.Items.Clear();
                NumberSearch(N);
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        void NumberSearch(int Num) 
        {
            for (int i = 0; i < Num; i++)
            {
                int sum = 0;
                int temp = i;
                int digitsCount = i.ToString().Length;
                int digit = 0;

                while (temp > 0)  // Пока число больше 0 
                {
                    digit = temp % 10;   // Находим последнюю цифру от числа
                    sum += (int)Math.Pow(digit, digitsCount);  // Суммируем цифру на стеень количество чисел
                    temp /= 10;   // отбрасываем последнее число
                }

                if (sum == i)
                {
                    
                        ListBoxNumbers.Items.Add(i);
                    
                }
            }
        }


    }
}
