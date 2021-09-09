using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        List<string> LINK = new List<string>();
        List<string> Description = new List<string>();
        string URL;
        int titlenum;
        //int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
        }

        //指定したURL先からXMLデータを取得し title要素 を取得し、リストボックスへセットする
        private void setRssTitle(string uri)
        {
            lbTitles.Items.Clear();
            LINK.Clear();
            Description.Clear();
            URL = uri;
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var titles = xdoc.Root.Descendants("title");
                var links = xdoc.Root.Descendants("link");
                var dcriptions = xdoc.Root.Descendants("description");
                foreach (var title in titles)
                {
                    lbTitles.Items.Add(title.Value);
                }
                foreach (var link in links)
                {
                    LINK.Add(link.Value);
                }
                foreach (var d in dcriptions)
                {
                    Description.Add(d.Value);
                }
                lbTitles.Items.RemoveAt(0);
                LINK.RemoveAt(0);
                Description.RemoveAt(0);
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            titlenum = lbTitles.SelectedIndex;
            if (titlenum != -1)
            {
                lbDescription.Text = Description[titlenum];
            }
            #region
            /*
             * num = 0;
            foreach (var d in Description)
            {
                if (num++ == titlenum)
                {
                    lbDescription.Text = d;
                }
            }
            */
            #endregion
        }

        private void selectLinkUrl(int titlenum)
        {
            wbBrowser.Url = new Uri(LINK[titlenum]);
            #region
            /*
             * num = 0;
            foreach (var link in LINK)
            {
                if (num++ == titlenum)
                {
                    wbBrowser.Url = new Uri(link);
                }
                    
            }
            */
            #endregion
        }

        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (titlenum != -1)
            {
                selectLinkUrl(titlenum);
            }
        }

        private void btWebBrowser_Click(object sender, EventArgs e)
        {
            if (titlenum != -1)
            {
                selectLinkUrl(titlenum);
            }
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
