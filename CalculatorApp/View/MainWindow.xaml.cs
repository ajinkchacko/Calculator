using CalculatorApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        CalculatorOneVM calculatorOneVM;
        CalculatorTwoVM calculatorTwoVM;

        char[] validChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
        char[] validCharsWithComma = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',' };


        public MainWindow()
        {
            calculatorOneVM = new CalculatorOneVM();
            calculatorTwoVM = new CalculatorTwoVM();

            InitializeComponent();
        }

        /// <summary>
        /// Calculator One
        /// Arithmetic mean of a list of numbers input
        /// </summary>
        private void btnCalcMean_Click(object sender, RoutedEventArgs e)
        {
            txtMeanResult.Text = calculatorOneVM.FindArithmeticMean(txtMeanNumbers.Text);
        }

        /// <summary>
        /// Calculator One
        /// Standard deviation for a list of numbers
        /// </summary>
        private void btnCalcStdDeviation_Click(object sender, RoutedEventArgs e)
        {
            txtStdDeviationResult.Text = calculatorOneVM.FindStandardDeviation(txtStdDeviationNumbers.Text);
        }

        /// <summary>
        /// Calculator One
        /// Frequencies of numbers in bins of 10
        /// </summary>
        private void btnCalcFreq_Click(object sender, RoutedEventArgs e)
        {
            listFreqResult.Items.Clear();

            var frequencies = new Dictionary<string, int>();

            txtFreqResult.Text = calculatorOneVM.FindtheFrequenciesOfNumbers(txtFreqNumbers.Text, ref frequencies);
            foreach (var frq in frequencies)
            {
                listFreqResult.Items.Add(new ListBoxItem()
                {
                    Content = frq.Key + " : " + frq.Value,
                    FontSize = 14,
                    FontWeight = FontWeights.Medium
                });
            }
        }

        /// <summary>
        /// Calculator One
        /// Square root of a number
        /// </summary>
        private void btnCalcSqrt_Click(object sender, RoutedEventArgs e)
        {
            txtSqrtResult.Text = calculatorOneVM.FindSquareRoot(txtSqrtNumber.Text);
        }

        /// <summary>
        /// Calculator Two
        /// Compound increase of a value 
        /// </summary>
        private void btnCalcCompInc_Click(object sender, RoutedEventArgs e)
        {
            txtCompIncResult.Text = calculatorTwoVM.FindCompoundIncrease(txtValueInc.Text, txtInterestInc.Text, txtYearsInc.Text);
        }

        /// <summary>
        /// Calculator Two
        /// Compound decrease of a value 
        /// </summary>
        private void btnCalcCompDec_Click(object sender, RoutedEventArgs e)
        {
            txtCompDecResult.Text = calculatorTwoVM.FindCompoundDecrease(txtValueDec.Text, txtInterestDec.Text, txtYearsDec.Text);
        }

        /// <summary>
        /// Restrict the text input to 0-9, decimal point and comma
        /// </summary>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox != null)
            {
                string result = "";
                foreach (char c in textBox.Text)
                {
                    if (Array.IndexOf(validCharsWithComma, c) != -1)
                        result += c;
                }
                textBox.Text = result;
                textBox.CaretIndex = result.Length;
            }
        }

        /// <summary>
        /// Restrict the text input to 0-9 and decimal point
        /// </summary>
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
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

    }
}
