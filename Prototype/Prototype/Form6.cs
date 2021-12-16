using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        //部活動登録画面に移動
        private void btClubRegister_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        //部費決算報告書画面に移動
        private void btManage_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
