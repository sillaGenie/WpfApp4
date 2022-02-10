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

namespace WpfApp4
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
            double resDouble = rateDollar * sumDollar;
            result.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rateEv.Text);
            double sumEvro = Convert.ToDouble(sumEv.Text);
            double resEvro = rateEvro * sumEvro;
            resultEv.Text = resEvro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateG.Text);
            double sumGrivna = Convert.ToDouble(sumG.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resultG.Text = resGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rateD.Text);
            double sumDrama = Convert.ToDouble(sumD.Text);
            double resDrama = rateDrama * sumDrama;
            resultD.Text = resDrama.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double sumInch = Convert.ToDouble(sumDm.Text);
            resultDm.Text = (0.0254 * sumInch).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double sumFeet = Convert.ToDouble(sumF.Text);
            resultF.Text = (0.3048 * sumFeet).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double sumMile = Convert.ToDouble(sumM.Text);
            resultM.Text = (1609.34 * sumMile).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double sumVerst = Convert.ToDouble(sumV.Text);
            resultV.Text = (1066.8 * sumVerst).ToString();
        }
    }
}
