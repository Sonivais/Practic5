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

namespace P5.Zadanie_2
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

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TextBox2.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TextBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add($"{TextBox1.Text}\n{TextBox2.Text}");
        }

        private void ButtonOKClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBox1.Text, out int a) && int.TryParse(TextBox2.Text, out int b))
            {
                int count = 0;
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                Answer.Text += $"Всего четных чисел {count}\n";
            }
        }

        private void ButtonCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
