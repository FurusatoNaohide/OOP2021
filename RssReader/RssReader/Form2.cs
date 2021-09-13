using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            if (wbBrowser.CanGoBack)
            {
                wbBrowser.GoBack();
            }
        }

        private void btGoForWard_Click(object sender, EventArgs e)
        {
            if (wbBrowser.CanGoForward)
            {
                wbBrowser.GoForward();
            }
        }

        private void wbBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            if (wbBrowser.CanGoBack)
            {
                btGoBack.Enabled = true;
            }
            else
            {
                btGoBack.Enabled = false;
            }

            if (wbBrowser.CanGoForward)
            {
                btGoForWard.Enabled = true;
            }
            else
            {
                btGoForWard.Enabled = false;
            }
        }
    }
}
