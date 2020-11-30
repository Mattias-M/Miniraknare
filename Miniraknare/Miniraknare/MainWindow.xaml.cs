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

namespace Miniraknare
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                switch (button.Content)
                {

                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "+":
                    case "-":
                    case "/":
                    case "*":

                        textblock.Text += button.Content;
                        break;
                    case "=":
                        textblock.Text += button.Content;
                        if (textblock.Text.Contains('+'))
                        {
                            textblock.Text += calculation('+');
                        }
                        else if (textblock.Text.Contains('-'))
                        {
                            textblock.Text += calculation('-');
                        }
                        else if (textblock.Text.Contains('/'))
                        {
                            textblock.Text += calculation('/');
                        }
                        else if (textblock.Text.Contains('*'))
                        {
                            textblock.Text += calculation('*');
                        }

                        break;
                    case "AC":
                        textblock.Text = "";
                        break;


                }
              
               
            }
        }

        public String calculation(char countingSign)
        {
            var listText = textblock.Text.Split('+', '-', '/', '*' );

            var firstNumber = Convert.ToDouble(listText[0]);
            var secondNuber = (listText[1]);

            var result = 0.0;
            switch (countingSign)
            {
                case '+':
                    result = firstNumber + secondNuber;
                    break;
                case '-':
                    result = firstNumber - secondNuber;
                    break;
                case '/':
                    result = firstNumber / secondNuber;
                    break;
                case '*':
                    result = firstNumber * secondNuber;
                    break;



            }
            string resultString = Convert.ToString(result);
            return resultString;
        }
        




    }
}
