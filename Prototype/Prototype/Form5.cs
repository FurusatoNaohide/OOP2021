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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //データベースを参照して部活IDとパスワードの組み合わせが合致したらログイン完了
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
