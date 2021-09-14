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
        #region Form2でURL検索
        /*
        Uri url; //表示するURL;
        
        public Form2(string url)
        {
            //InitializeComponent();
            this.url = new Uri(url);
        }
        */
        #endregion
        //コンストラクタ
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form2でURL検索
            //wbBrowser.Url = url;
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
        }

        //ページの読み込みが完了すると呼ばれる
        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btGoBack.Enabled = wbBrowser.CanGoBack;
            btGoForWard.Enabled = wbBrowser.CanGoForward;
        }
    }
}
