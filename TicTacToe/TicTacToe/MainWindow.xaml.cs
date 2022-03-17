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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int turn;

        public MainWindow()
            : base()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            turn = 1;
        }

        private void Win(string btnContent)
        {
            if ((Button1.Content == btnContent & Button2.Content == btnContent &
                 Button3.Content == btnContent)
               | (Button1.Content == btnContent & Button4.Content == btnContent &
                 Button7.Content == btnContent)
               | (Button1.Content == btnContent & Button5.Content == btnContent &
                 Button9.Content == btnContent)
               | (Button2.Content == btnContent & Button5.Content == btnContent &
                 Button8.Content == btnContent)
               | (Button3.Content == btnContent & Button6.Content == btnContent &
                 Button9.Content == btnContent)
               | (Button4.Content == btnContent & Button5.Content == btnContent &
                 Button6.Content == btnContent)
               | (Button7.Content == btnContent & Button8.Content == btnContent &
                 Button9.Content == btnContent)
               | (Button3.Content == btnContent & Button5.Content == btnContent &
                 Button7.Content == btnContent))
            {
                if (btnContent == "O")
                {

                    MessageBox.Show("PLAYER O WINS");
                }
                else if (btnContent == "X")
                {
                    MessageBox.Show("PLAYER X WINS");
                }
                Disablebuttons();
            }

            else
            {
                foreach (Button btn in wrapPanel1.Children)
                {
                    if (btn.IsEnabled == true)
                        return;
                }
                MessageBox.Show("GAME OVER NO ONE WINS");
            }
        }
        private void Disablebuttons()
        {
            foreach (Button btn in wrapPanel1.Children)
            {
                btn.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (turn == 1)
            {
                btn.Content = "O";
                Label0.Content = "X";
            }
            else
            {
                btn.Content = "X";
                Label0.Content = "O";
            }
            btn.IsEnabled = false;
            Win(btn.Content.ToString());
            turn += 1;
            if (turn > 2)
                turn = 1;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RESET_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
