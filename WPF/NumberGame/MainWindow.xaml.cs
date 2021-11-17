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
        private const int Rows = 5;//行
        private const int Colums = 5;//列
        Random randoms = new Random();
        public MainWindow()
        {
            InitializeComponent();
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
        //ロード時に一度だけ実行される
        private void MainDisp_Loaded(object sender, RoutedEventArgs e)
        {
            //List<Button> buttons = new List<Button>();
            //正解を取得
            Rnum = new Random().Next(1, 25);
            TbMessage.Text = string.Format("選ばれた数字を{0}回以内で当ててください", Count);

            /*可変
            Rnum = randoms.Next(Rows, Colums) + 1;

            //行
            for (int i = 0; i < Rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            //列
            for (int j = 0; j < Colums; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colums; j++)
                {
                    var bt = new Button();
                    bt.Width = MainForm.Width / Colums;
                    bt.Height = MainForm.Height / Rows;
                    bt.Content = (j + 1)+(i * 5);
                    bt.FontSize = 20;
                    bt.Click += Bt_Click;
                    Grid.SetRow(bt, 1);
                    Grid.SetColumn(bt, 1);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainForm.Height += textDisp.Height + 50;
            */
        }
            
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button selectedButton = (Button)sender;
            int num = (int)selectedButton.Content;
        }
        
    }
}
