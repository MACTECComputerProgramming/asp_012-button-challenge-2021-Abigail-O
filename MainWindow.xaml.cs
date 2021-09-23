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

namespace radio_button_challenge_2
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
            if (button1.IsChecked == true)
            {
                answerLabel.Content = " Pencil, very reliable!";

                pencil.Opacity = 100;

                pen.Opacity = 0;

                phone.Opacity = 0;

                pad.Opacity = 0;
            }
            else if (button2.IsChecked == true)
            {
                answerLabel.Content = " Pen, nice choice!";

                pen.Opacity = 100;

                pencil.Opacity = 0;

                phone.Opacity = 0;

                pad.Opacity = 0;
            }
            else if (button3.IsChecked == true)
            {
                answerLabel.Content = " Phone, must be from the future!";

                phone.Opacity = 100;

                pencil.Opacity = 0;

                pen.Opacity = 0;

                pad.Opacity = 0;
            }
            else if (button4.IsChecked == true)
            {
                answerLabel.Content = " Pad, welcome to 2021!";

                pad.Opacity = 100;

                pencil.Opacity = 0;

                pen.Opacity = 0;

                phone.Opacity = 0;
            }


        }
    }
}
