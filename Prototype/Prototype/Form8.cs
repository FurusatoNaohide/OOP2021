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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //範囲指定
            selectedRange();
            //月毎決算ならデフォルトは今年度で1月～12月のどれかを指定
            //年度決算ならデフォルトは今年度で過去の年度もComboBoxで指定可能
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void selectedRange()
        {
            if (gbRange.TabIndex == 1)
            {
                cbYear.Enabled = true;
                gbMonth.Enabled = false;
            }
            else
            {
                cbYear.Enabled = false;
                gbMonth.Enabled = true;
            }
        }
    }
}
