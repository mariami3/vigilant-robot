using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace p1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;
        bool pc = false;
        int hod = 1;
        bool turn = true; 
        int turn_count = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 500;
            this.Width = 500;

        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            /*switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    break;

                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    break; 
            }
            /*MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());*/
            /*sender.GetType().GetProperty("Enabled").SetValue(sender, false);*/


        }
        private void chekwin()
        {
            Random rnd = new Random();
            int p = rnd.Next(0, 8);

            if (pc && (name != _1.Text) && (name != _2.Text) && (name != _3.Text)
                && (name != _4.Text) && (name != _5.Text) && (name != _6.Text) && (name != _7.Text)
                && (name != _8.Text) && (name != _9.Text))
            {
                switch (p)
                {
                    case 0:
                        _1.Text = "O";
                        _1.Enabled = false;
                        turn_count++;
                        break;
                    case 1:
                        _2.Text = "O";
                        _2.Enabled = false;
                        turn_count++;
                        break;
                    case 2:
                        _3.Text = "O";
                        _3.Enabled = false;
                        turn_count++;
                        break;
                    case 3:
                        _4.Text = "O";
                        _4.Enabled = false;
                        turn_count++;
                        break;
                    case 4:
                        _5.Text = "O";
                        _5.Enabled = false;
                        turn_count++;
                        break;
                    case 5:
                        _6.Text = "O";
                        _6.Enabled = false;
                        turn_count++;
                        break;
                    case 6:
                        _7.Text = "O";
                        _7.Enabled = false;
                        turn_count++;
                        break;
                    case 7:
                        _8.Text = "O";
                        _8.Enabled = false;
                        turn_count++;
                        break;
                    case 8:
                        _9.Text = "O";
                        _9.Enabled = false;
                        turn_count++;
                        break;
                }
            }
        }

        private void CheckWinner()
        {
            bool it_is_win = false;

            // Проверка по горизонтали
            if ((_1.Text == _4.Text) && (_4.Text == _7.Text) && (!_1.Enabled))
                it_is_win = true;

            else if ((_2.Text == _5.Text) && (_5.Text == _8.Text) && (!_2.Enabled))
                it_is_win = true;

            else if ((_3.Text == _6.Text) && (_6.Text == _9.Text) && (!_3.Enabled))
                it_is_win = true;

            // Проверка по вертикали
            if ((_1.Text == _2.Text) && (_2.Text == _3.Text) && (!_1.Enabled))
                it_is_win = true;

            else if ((_4.Text == _5.Text) && (_5.Text == _6.Text) && (!_4.Enabled))
                it_is_win = true;

            else if ((_7.Text == _8.Text) && (_8.Text == _9.Text) && (!_7.Enabled))
                it_is_win = true;

            // Проверка по диагонали
            if ((_1.Text == _5.Text) && (_5.Text == _9.Text) && (!_1.Enabled))
                it_is_win = true;

            else if ((_3.Text == _5.Text) && (_5.Text == _7.Text) && (!_7.Enabled))
                it_is_win = true;

            if (it_is_win)
            {
                DisableButton();
                string winner = turn ? "X" : "O"; 
                MessageBox.Show(winner + " Победа");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Ничья");
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            pc = true;
            name = button.Name;
            label1.Text = name + label1.Text;
            button.Enabled = false;
            turn_count++;
            label1.Text = turn_count.ToString();

            CheckWinner();
            Check();
        }
        private void DisableButton()
        {
            foreach (Control c in Controls)
            {
                if (c is Button button)
                {
                    button.Enabled = false;
                }
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c is Button button)
                {
                    button.Enabled = true;
                    button.Text = ""; // Очистка текста кнопки для новой игры
                }
            }
        }
    }
}