using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Weight_Converter
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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            double userNumber = Convert.ToDouble(fromInput.Text);
            var userChoice = unitsChoice.Text;
            var answer = Math.Round((userNumber * 2.2),2);
            toOutput.Text = $"{answer} lbs.";

            /*switch (userChoice)
            {
                case "KG to lbs":
                    answer = userNumber * 2.2;
                    answerStr = Convert.ToString(answer);
                    
                    break;
            }*/

        }
    }
}
