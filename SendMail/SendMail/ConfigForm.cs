using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            tbHost.Text = set.sHost();
            tbPort.Text = set.sPort();
            tbUserName.Text = set.sMailAddr();
            tbPass.Text = set.sPass();
            cbSsl.Checked = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Host = tbHost.Text;
            set.Port = int.Parse(tbPort.Text);
            set.MailAddr = tbUserName.Text;
            set.Pass = tbPass.Text;
        }
    }
}
