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

namespace _4_Task
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resSumDollar = rateDollar * sumDollar;
            resSum.Text = resSumDollar.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resSumEuro = rateEuro * sumEuro;
            resSum1.Text = resSumEuro.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate2.Text);
            double sumGrivn = Convert.ToDouble(sum2.Text);
            double resSumGrivn = rateGrivn * sumGrivn;
            resSum2.Text = resSumGrivn.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resSumDram = rateDram * sumDram;
            resSum3.Text = resSumDram.ToString();
        }

        private void Button_Metr(object sender, RoutedEventArgs e)
        {
            double numIn = Convert.ToDouble(num.Text);
            double resultM = numIn * 0.0254;
            result.Text = resultM.ToString();
        }

        private void Button_Metr1(object sender, RoutedEventArgs e)
        {
            double numIn1 = Convert.ToDouble(num1.Text);
            double resultM1 = numIn1 * 0.3048;
            result1.Text = resultM1.ToString();
        }

        private void Button_Metr2(object sender, RoutedEventArgs e)
        {
            double numIn2 = Convert.ToDouble(num2.Text);
            double resultM2 = numIn2 * 1609.34;
            result2.Text = resultM2.ToString();
        }

        private void Button_Metr3(object sender, RoutedEventArgs e)
        {
            double numIn3 = Convert.ToDouble(num3.Text);
            double resultM3 = numIn3 * 1066.8;
            result3.Text = resultM3.ToString();
        }
    }
}
