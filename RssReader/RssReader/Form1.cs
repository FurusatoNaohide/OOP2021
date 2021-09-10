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
    #region 匿名クラスを用いた要素取り出し
    /*
    public class ItemData
    {


    }
    */
    #endregion
    public partial class Form1 : Form
    {
        //IEnumerable<ItemData> items = null;

        List<string> LINK = new List<string>();
        //List<DateTime> pubDate = new List<DateTime>();
        List<string> pubDate = new List<string>();
        List<string> Description = new List<string>();
        DateTime dt;
        int titlenum;

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
            pubDate.Clear();
            Description.Clear();

            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var items = xdoc.Root.Descendants("item");

                #region 匿名クラスを用いた要素取り出し
                /*
                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                });
                */
                #endregion
                ;
                #region
                /*
                var titles = xdoc.Root.Descendants("title");
                var links = xdoc.Root.Descendants("link");
                var pubdates = xdoc.Root.Descendants("pubDate");
                var dcriptions = xdoc.Root.Descendants("description");
                */
                #endregion 
                foreach (var item in items)
                {
                    #region 匿名クラスを用いた要素取り出し
                    /*
                    lbTitles.Items.Add(item.Title);
                    LINK.Add(item.Link);
                    pubDate.Add(item.PubDate);
                    Description.Add(item.Description);
                    */
                    #endregion
                    lbTitles.Items.Add(item.Element("title").Value);
                    LINK.Add(item.Element("link").Value);
                    if (DateTime.TryParse(item.Element("pubDate").Value, out dt) == true)
                    {
                        pubDate.Add(dt.ToString("yyyy/MM/dd HH:mm:ss"));
                    }
                    Description.Add(item.Element("description").Value);
                    
                }

                #region
                /*
                foreach (var title in titles)
                {
                    lbTitles.Items.Add(title.Value);
                }
                foreach (var link in links)
                {
                    LINK.Add(link.Value);
                }
                foreach (var date in pubdates)
                {
                    //pubDate.Add(DateTime.ParseExact(date.Value,format,null));
                    pubDate.Add(date.Value);
                }
                foreach (var d in dcriptions)
                {
                    Description.Add(d.Value);
                }
                */
                #endregion
                lbTitles.Items.RemoveAt(0);
                LINK.RemoveAt(0);
                pubDate.RemoveAt(0);
                Description.RemoveAt(0);
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            titlenum = lbTitles.SelectedIndex;
            lbDescription.Text = "";
            if (titlenum != -1)
            {
                lbDescription.Text += pubDate[titlenum] + "\r\n" + Description[titlenum] + "\r\n";
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
#if false
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
                //匿名クラスを用いた要素取り出し
                //string link = (items.ToArray())[lbTitles.SelectedIndex].Link; //配列へ変換して[]でアクセス
                selectLinkUrl(titlenum);
            }
        }
#endif
        private void btWebBrowser_Click(object sender, EventArgs e)
        {
            if (titlenum != -1)
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.wbBrowser.Url = new Uri(LINK[titlenum]);
            }
        }
    }
}
