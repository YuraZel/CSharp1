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

namespace Task1WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            textBox2.Visibility = Visibility.Hidden;
            textBox3.Visibility = Visibility.Hidden;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, p, s;
            p = (To(textBox1.Text) + Convert.ToDouble(textBox2.Text)) * 2;
            s = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text); ;
            textBox2.Text = ToString(p);
            textBox3.Text = ToString(s);
            label2.Visibility = Visibility.Visible;
            label3.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            textBox3.Visibility = Visibility.Visible;
        }
    }
}
