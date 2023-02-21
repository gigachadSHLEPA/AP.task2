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

namespace AP.task2
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

    

        private void MNBTN7_Click(object sender, RoutedEventArgs e)
        {
            double k = 8.2;
            double x = 5;
            double c = Math.Sqrt(x);
            double a = Math.Pow(c, 4) + Math.Pow(k, 3);
            double y = Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(x), 5);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN18_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN19_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN21_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MNBTN22_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN24_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN27_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN28_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN29_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MNBTN30_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
