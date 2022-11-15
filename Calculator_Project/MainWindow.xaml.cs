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

namespace Calculator_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long _number1 = 0;
        long _number2 = 0;
        string _operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag; 
            int num = int.Parse(tag.ToString()); 
            if (_operation == "")
            {
                _number1 = (_number1 * 10) + num;
                Display_txtBox.Text = _number1.ToString();
            }
            else 
            {
                _number2 = (_number2 * 10) + num;
                Display_txtBox.Text = _number2.ToString();
            }
        }

        private void MathOp_Click(object sender, RoutedEventArgs e) 
        {
            var tag = ((Button)sender).Tag;
            string op = tag.ToString();

            switch (op) 
            {
                case "+":
                    _operation = "+";
                    Display_txtBox.Text = "0";
                    break;
                case "-":
                    _operation = "-";
                    Display_txtBox.Text = "0";
                    break;
                case "*":
                    _operation = "*";
                    Display_txtBox.Text = "0";
                    break;
                case "/":
                    _operation = "/";
                    Display_txtBox.Text = "0";
                    break;
                case "=":
                    Equal_Op();
                    break;
            }
        }

        private void Equal_Op()
        {
            switch (_operation)
            {
                case "+":
                    Display_txtBox.Text = (_number1 + _number2).ToString();
                    break;
                case "-":
                    Display_txtBox.Text = (_number1 - _number2).ToString();
                    break;
                case "*":
                    Display_txtBox.Text = (_number1 * _number2).ToString();
                    break;
                case "/":
                    Display_txtBox.Text = (_number1 / _number2).ToString();
                    break;
            }
        }

        private void ClearEntry_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _number1 = 0;
            }
            else 
            {
                _number2 = 0;
            }

            Display_txtBox.Text = "0";
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            _number1 = 0;
            _number2 = 0;
            _operation = "";
            Display_txtBox.Text = "0";
        }

        private void Backspace_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _number1 /= 10;
                Display_txtBox.Text = _number1.ToString();
            }
            else
            {
                _number2 /= 10 ;
                Display_txtBox.Text = _number2.ToString();
            }
        }

        private void PositiveNegative_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _number1 *= -1;
                Display_txtBox.Text = _number1.ToString();
            }
            else
            {
                _number2 *= -1;
                Display_txtBox.Text = _number2.ToString();
            }
        }
    }
}
