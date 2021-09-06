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
            var title = lbTitles.SelectedItem.ToString();
            selectLinkUrl(title);
        }

        private void selectLinkUrl(string Title)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(tbUrl.Text);

                XDocument xdoc = XDocument.Load(stream);
                var title = xdoc.Root.Elements().Where(x => (string)x.Element("title") == Title);
            }
        }
    }
}
