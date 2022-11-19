using CalculatorApp.ViewModel;
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

namespace CalculatorApp
{

    public partial class MainWindow : Window
    {

        char[] validChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' };

        CalculatorOneVM calculatorOneVM;
        CalculatorTwoVM calculatorTwoVM;
        
        public MainWindow()
        {
            calculatorOneVM = new CalculatorOneVM();
            calculatorTwoVM = new CalculatorTwoVM();

            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
            {
                string result = "";
                foreach (char c in textBox.Text)
                {
                    if (Array.IndexOf(validChars, c) != -1)
                        result += c;
                }
                textBox.Text = result;
                textBox.CaretIndex = result.Length;
            }
        }

        private void btnCalcMean_Click(object sender, RoutedEventArgs e)
        {
            txtMeanResult.Text = calculatorOneVM.FindArithmeticMean(txtMeanNumbers.Text);
        }

        private void btnCalcStdDeviation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcFreq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcSqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcCompInc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcCompDec_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
