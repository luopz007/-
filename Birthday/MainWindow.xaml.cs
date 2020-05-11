using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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

namespace Birthday
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int input1, input2, input3, input4;


        public MainWindow()
        {
            InitializeComponent();
            closeButton.Visibility = Visibility.Hidden;
            returnButton.Visibility = Visibility.Hidden;
            num1.Focus();
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (closeButton.Visibility == Visibility.Hidden)
            {
                e.Cancel = true;
                lable.Content = "放弃了？";
                closeButton.Visibility = Visibility.Visible;
                returnButton.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (input1 == 8 && input2 == 0 && input3 == 2 && input4 == 3)
            {
                SuccessWindow window = new SuccessWindow();
                window.Show();
                closeButton.Visibility = Visibility.Visible;
                this.Close();
            }
            else
            {
                var errorWindow = new ErrorWindow();
                errorWindow.Show();
                SoundPlayer player = new SoundPlayer();
                player.Stream = Properties.Resources.errorMusic;
                player.Play();
            }
        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {
            input1 = CheckTextBox.ChangeTextBox(num1, num1, num2);
        }

        private void num2_TextChanged(object sender, TextChangedEventArgs e)
        {
            input2 = CheckTextBox.ChangeTextBox(num1, num2, num3);
        }

        private void num3_TextChanged(object sender, TextChangedEventArgs e)
        {
            input3 = CheckTextBox.ChangeTextBox(num2, num3, num4);
        }

        private void num4_TextChanged(object sender, TextChangedEventArgs e)
        {
            input4 = CheckTextBox.ChangeTextBox(num3, num4, num4);
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            lable.Content = "";
            closeButton.Visibility = Visibility.Hidden;
            returnButton.Visibility = Visibility.Hidden;
        }
    }
}
