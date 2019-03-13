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

namespace SecondMeet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void touch1(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void touch2(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Answer.Text = number2.ToString();
            }
        }
        private void touch3(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Answer.Text = number2.ToString();
            }
        }
        private void touch4(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Answer.Text = number2.ToString();
            }
        }
        private void touch5(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Answer.Text = number2.ToString();
            }
        }
        private void touch6(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Answer.Text = number2.ToString();
            }
        }
        private void touch7(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Answer.Text = number2.ToString();
            }
        }
        private void touch8(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Answer.Text = number2.ToString();
            }
        }
        private void touch9(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Answer.Text = number2.ToString();
            }
        }
        private void touch10(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Answer.Text = number2.ToString();
            }
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            operation = "+";
            Answer.Text = "0";
        }

        private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            operation = "*";
            Answer.Text = "0";
        }

        private void Button_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            operation = "/";
            Answer.Text = "0";
        }

        private void Button_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            operation = "-";
            Answer.Text = "0";
        }

        private void Button_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Answer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Answer.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Answer.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Answer.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) ;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Answer.Text = number2.ToString();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Answer.Text = "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Answer.Text = "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Answer.Text = "0";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Answer.Text = "0";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Answer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Answer.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Answer.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Answer.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            operation = "";
                number1 = 0;
              
            
            
                number2 = 0;
                Answer.Text = "0";
           
        }
    }
}
