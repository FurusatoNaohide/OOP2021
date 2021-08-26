using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("novelists.xml");//XMLドキュメントを読み込む
            #region
            //var xelements = xdoc.Root.Elements()
            //        .Where(x => ((DateTime)x.Element("birth")).Year >= 1900);//DateTimeで型変換してYear飲み取り出す
            //var xelements = xdoc.Root.Elements()
            //        .OrderBy(x => (string)(x.Element("birth")));
            #endregion
            foreach (var xnovelist in xdoc.Root.Elements())
            {
                var xname = xnovelist.Element("name");
                var works = xnovelist.Element("masterpieces")
                                     .Elements("title")
                                     .Select(x=>x.Value);
                
                Console.WriteLine("{0} - {1}",xname.Value,string.Join(",",works)); 

                #region
                //XAttribute xkana = xname.Attribute("kana");
                //Console.WriteLine("{0} {1}", xname.Value, xkana?.Value); //null条件演算子付き

                //var xbirth = xnovelist.Element("birth");
                //Console.WriteLine("{0} {1}", xname.Value, xbirth.Value);
                #endregion
            }
        }
    }
}
