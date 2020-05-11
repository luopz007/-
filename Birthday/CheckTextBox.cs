using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Birthday
{
    public class CheckTextBox
    {
        public static int ChangeTextBox(TextBox num0, TextBox num1, TextBox num2)
        {
            int text1 = -1;
            switch (num1.Text.Length)
            {
                case 0:
                    num0.Focus();
                    //Keyboard.Focus(num0);
                    num0.SelectionStart = 1;
                    break;
                case 1:
                    if (!int.TryParse(num1.Text, out text1))
                    {
                        num1.Text = "";
                        num0.Focus();
                        //Keyboard.Focus(num0);
                        num0.SelectionStart = 1;
                    }
                    break;
                default:
                    string strText = num1.Text;
                    char strText1 = strText[0], strText2 = strText[1];
                    num1.Text = strText1.ToString();
                    num2.Focus();
                    num2.Text = strText2.ToString();
                    num2.SelectionStart = 1;
                    text1 = int.Parse(strText1.ToString());
                    break;
            }
            return text1;
        }
    }
}
