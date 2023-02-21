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
            double x = 2.8, y = 0, a = 0, b = 1.3, c = 0;
            c = Math.Pow(a, 2) + Math.Sqrt(b);
            a = Math.Pow(b, 3) + Math.ILogB(Math.Sqrt(b));
            y = Math.Exp(x) + Math.Pow(5.8, c);
            MessageBox.Show($"F(x)={y}");
        }

        private void MNBTN10_Click(object sender, RoutedEventArgs e)
        {
            double x = 2, y = 0, a = 0, b = 7, c = 0;
            c = Math.Log10(Math.Abs(b));
            a = Math.Pow(b + x, 3);
            y = Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
            MessageBox.Show($"F(x)={y}");
        }

        private void MNBTN11_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, q = 2, b = 1.8, t = 0;
            t = Math.Pow(b, 3) + Math.Exp(Math.Sqrt(q));
            x = Math.Pow(t, 3) + Math.Pow(b, 2);
            y = Math.Pow(Math.Atan(Math.Sqrt(x)), 2);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN12_Click(object sender, RoutedEventArgs e)
        {
            double z = 0, y = 0, w = 0, x = 1.9, a = -0.9;
            w = Math.Pow(x, 2) * Math.Sqrt(Math.Abs(a + x));
            z = Math.Pow(Math.Cos(a), 2) + Math.Pow(w, 2);
            y = a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN13_Click(object sender, RoutedEventArgs e)
        {
            double k = 3.4, y = 0, b = 6, t = 0, a = 0;
            t = Math.Pow(b, 2) + Math.Pow(k, 3);
            a = Math.Sqrt(b + t);
            y = Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN14_Click(object sender, RoutedEventArgs e)
        {
            double k = 3.4, y = 0, b = 6, t = 0, a = 0;
            t = Math.Pow(b, 2) + Math.Pow(k, 3);
            a = Math.Sqrt(b + t);
            y = Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN15_Click(object sender, RoutedEventArgs e)
        {
            double p = 4, y = 0, b = 0, x = 0, a = 5.5;
            b = Math.Abs(a) + Math.Sqrt(a + Math.Pow(p, 2));
            x = Math.Exp(b);
            y = Math.Pow(Math.Cos(x), 3) + Math.Abs(a);
            MessageBox.Show($"F(x) = {y}");
        }

        
        private void MNBTN22_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, p = 4, m = 5.7, t = 0;
            t = Math.Pow(Math.Sin(m), 3);
            x = Math.Pow(p, 2) + t;
            y = Math.Pow(Math.Log10(Math.Abs(x + t)), 4);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN23_Click(object sender, RoutedEventArgs e)
        {
            double x = 5.2, y = 0, a = 0, b = 0.3, t = 0;
            t = x * Math.Pow(b, 2) + Math.Sqrt(x);
            x = Math.Log10(Math.Abs(t * x + Math.Pow(b, 2)));
            y = Math.Pow(Math.ILogB(Math.Pow(a, 2) / (a + t)), a + b);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN24_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, b = 1.8, t = 6.2, a = 0;
            a = Math.Pow(t, 2) * b;
            x = Math.Pow(a, 3) + Math.Sqrt(t + b);
            y = Math.Pow(Math.Cos(x), 5) - b * Math.Pow(Math.Sin(x), 2);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN25_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, t = 0, p = 2.6, a = 2;
            t = Math.Pow(p, 3) + Math.Pow(a, 3);
            x = Math.Exp(Math.Sqrt(p + a));
            y = Math.Pow(x, 3) / Math.Pow(t, 2);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN26_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, t = 2, b = 8.1, a = 0;
            t = Math.Sqrt(b + Math.Pow(t, 2));
            x = Math.Pow(Math.Cos(b), 2) + Math.Pow(Math.Sin(a), 2);
            y = Math.Pow(x, 2) / Math.Pow(Math.Sqrt(Math.Abs(x)), 3);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN27_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, y = 0, t = -3, c = 0, a = 76;
            c = Math.Pow(t, 2) + Math.Sqrt(a);
            x = Math.ILogB(Math.Abs(c * t)) + Math.Pow(a, 2);
            y = Math.Tan(4 * x) + Math.Pow(Math.Sin(x), 2);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN28_Click(object sender, RoutedEventArgs e)
        {
            double a = 0, y = 0, b = 2.19, t = 0, k = 1.7;
            t = Math.Pow(k, 2) + Math.Sqrt(b);
            a = b + Math.Pow(t, 2) * Math.Exp(t);
            y = Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN29_Click(object sender, RoutedEventArgs e)
        {
            double p = 0, y = 0, b = 4.3, x = 0, a = 6;
            x = Math.Exp(2 * a) + Math.Sqrt(b);
            p = x * (a + Math.Pow(b, 3));
            y = Math.Pow(Math.Log10(Math.Abs(p) + x), 3);
            MessageBox.Show($"F(x) = {y}");
        }

        private void MNBTN30_Click(object sender, RoutedEventArgs e)
        {
            double t = 3, y = 0, b = 4.2, x = 0, a = 0;
            a = t + Math.Pow(b, 3);
            x = Math.Pow(t, 2) * Math.Sqrt(Math.Abs(a + b));
            y = Math.Pow(Math.ILogB(Math.Abs(x + Math.Pow(a, 2))), 5);
            MessageBox.Show($"F(x) = {y}");
        }
    }
}
