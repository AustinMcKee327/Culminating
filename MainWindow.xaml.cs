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

namespace _184905NameSorter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UInt64 NameSum;
        UInt64 wordposition;
        UInt64 wordValue;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnread_Click(object sender, RoutedEventArgs e)
        {
            string output = "";
            System.IO.StreamReader sr = new System.IO.StreamReader("Names.txt");
        
            output = sr.ReadToEnd();
            output = output.ToUpper();
            string[] s = output.Split(',');
            

//            string lastWord = "";
            
            Array.Sort(s);
            //MessageBox.Show(s.Length.ToString());
            foreach (string word in s)
            {
                
                //lastWord = word;
                wordposition++;
                wordValue = 0;
                UInt64 placeholder = 0;
                //MessageBox.Show(word);
                for(UInt64 i=(UInt64)0; i<(UInt64)word.Length; i++)
                {
                    char Letter = word[(int)i];
                    //MessageBox.Show(word[i].ToString());
                    placeholder = Letter-(UInt64)64;
                    //MessageBox.Show(placeholder.ToString());
                    wordValue += placeholder;
                    //MessageBox.Show(NameSum.ToString());
                    
                }
                NameSum += wordValue * wordposition;

                //NameOutput.Text += word + " ";






            }
            LabelValue.Content = NameSum.ToString() + Environment.NewLine + lastWord;
        }
    }
}
