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

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWeathreView_Click(object sender, EventArgs e)
        {
            lbDetaul.Items.Clear();
            var select = 0;
            
            var Choise = cbSelectArea.Text;
            switch (Choise)
            {
                case "前橋":
                    select = 4210;
                    break;
                case "みなかみ":
                    select = 4220;
                    break;
                case "宇都宮":
                    select = 4110;
                    break;
                case "水戸":
                    select = 4010;
                    break;
                
            }
            var results = GetWeatherReportFromYahoo(select);
            foreach (var s in results)
            {
                lbDetaul.Items.Add(s);
            }
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }
    }
}
