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

namespace Machtverheffing
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        StringBuilder sb = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValidInput = double.TryParse(inputTextBox.Text, out double inputUser);
            double result;
           

            if (isValidInput = false || inputUser > 84)


            {

                resultTextBox.Text = ("Geef een correct getal! Deze mag niet groter zijn als 84!");
            }
            else
            {
                for (int i = 1; i < 11; i++)

                {
                    result = Math.Pow(inputUser, i);



                    sb.AppendLine ($"{inputUser} tot de macht van {i} = {result}");


                }

                resultTextBox.Text = sb.ToString();




            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            int start = 1;
            sb.Clear();
            resultTextBox.Clear();
            inputTextBox.Clear();
            inputTextBox.Focus();
            inputTextBox.Text = ($"{start}"); 
           
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
