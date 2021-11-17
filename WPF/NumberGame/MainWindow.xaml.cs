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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int Cnum;
        int Rnum;
        int Count = 5;
        public MainWindow()
        {
            InitializeComponent();
            Rnum = new Random().Next(1, 25);
            TbMessage.Text = string.Format("選ばれた数字を{0}回以内で当ててください",Count);
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Cnum = int.Parse(((Button)sender).Content.ToString());
            CheckNumber(Cnum);
        }

        public void CheckNumber(int num)
        {
            
            Count--;
            TbResult.Text = string.Format("あと{0}回 ", Count);
            if (Rnum > num)
            {
                TbResult.Text += "選ばれた数字より小さいです";
            }
            else if (Rnum < num)
            {
                TbResult.Text += "選ばれた数字より大きいです";
            }
            else
            {
                TbResult.Text = "あたり!";
                MessageBox.Show("あたり!\r\nCongratulations!");
                Close();
            }

            if (Count <= 0 && Rnum != num)
            {
                MessageBox.Show("Game Over");
                Close();
            }
        }
    }
}
