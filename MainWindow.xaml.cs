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

namespace _184905ThreeFiveMultiplesSum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int FinalSum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNcalculate_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i<334; i++)
            {
                MultiplesOutput.Text += i * 3 + ", ";
                FinalSum += i * 3;
                
            }
            MultiplesOutput.Text += Environment.NewLine;
            for(int j = 1; j<200; j++)
            {
                MultiplesOutput.Text += j * 5 + ", ";
                
                FinalSum += j * 5;
            }
            for (int k = 1; k < 67; k++)
            {
                FinalSum -= k * 15;
            }
            SumOutput.Content = FinalSum;
        }
    }
}
