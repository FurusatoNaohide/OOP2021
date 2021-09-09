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
        Dictionary<string, string> TitleLink = new Dictionary<string, string>();
        string URL;

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
            URL = uri;
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var titles = xdoc.Root.Descendants("title");
                foreach (var title in titles)
                {
                    lbTitles.Items.Add(title.Value);
                }
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var title = lbTitles.SelectedItem.ToString();
            var titlenum = lbTitles.SelectedIndex;
            if (titlenum != -1)
            {
                selectLinkUrl(titlenum);
            }
        }

        private void selectLinkUrl(int titlenum)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(URL);

                XDocument xdoc = XDocument.Load(stream);
                var links = xdoc.Root.Descendants("link");
                string Link = null;
                int num = 0;
                foreach (var link in links)
                {
                    if (num++ == titlenum)
                    {
                        Link = link.Value;
                    }
                    
                }
                wbBrowser.Url = new Uri(Link);
            }
        }
    }
}
