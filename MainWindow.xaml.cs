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
            
            switch (userChoice)
            {
                case "KG to lbs":
                    var answer = Math.Round((userNumber * 2.2),2);
                    var answerStr = Convert.ToString(answer);
                    toOutput.Text = $"{answerStr} lbs";
                    break;

                case "lbs to KG":
                    var answer1 = Math.Round((userNumber / 2.2),2);
                    var answerStr1 = Convert.ToString(answer1);
                    toOutput.Text = $"{answerStr1} KG";
                    break;

                case "grams to ounces":
                    var answer2 = Math.Round((userNumber / 28.35), 2);
                    var answerStr2 = Convert.ToString(answer2);
                    toOutput.Text = $"{answerStr2} ounces";
                    break;

                case "ounces to grams":
                    var answer3 = Math.Round((userNumber * 28.35), 2);
                    var answerStr3 = Convert.ToString(answer3);
                    toOutput.Text = $"{answerStr3} grams";
                    break;

            }

        }
    }
}
