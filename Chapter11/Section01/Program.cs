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
            var novelists = ReadNovelists();
            #region
            //var xelements = xdoc.Root.Elements()
            //        .Where(x => ((DateTime)x.Element("birth")).Year >= 1900);//DateTimeで型変換してYear飲み取り出す

            //var xelements = xdoc.Root.Elements()
            //        .OrderBy(x => (string)(x.Element("birth")));

            //var xtitles = xdoc.Root.Descendants("title");

            /*リスト11.9
            var novelists = xdoc.Root.Elements()
                                .Select(x => new
                                {
                                    Name = (string)x.Element("name"),
                                    Birth = (DateTime)x.Element("birth"),
                                    Death = (DateTime)x.Element("death")
                                });
            */
            #endregion
            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1}-{2}) - {3}",
                                    novelist.Name,novelist.Birth.Year,novelist.Death.Year,
                                    string.Join(",",novelist.Masterpieces));

                #region
                /*
                var xname = xnovelist.Element("name");
                var works = xnovelist.Element("masterpieces")
                                     .Elements("title")
                                     .Select(x => x.Value);
                Console.WriteLine("{0} - {1}", xname.Value, string.Join(",", works));
                */

                //XAttribute xkana = xname.Attribute("kana");
                //Console.WriteLine("{0} {1}", xname.Value, xkana?.Value); //null条件演算子付き

                //var xbirth = xnovelist.Element("birth");
                //Console.WriteLine("{0} {1}", xname.Value, xbirth.Value);

                //Console.WriteLine(xtitle.Value);
                #endregion
            }
        }
        //カスタムクラスのオブジェクトとして要素を取り出す
        static public IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");//XMLドキュメントを読み込む
            var novelists = xdoc.Root.Elements()
                                .Select(x => new Novelist
                                {
                                    Name = (string)x.Element("name"),
                                    KanaName = (string)(x.Element("name").Attribute("kana")),
                                    Birth = (DateTime)x.Element("birth"),
                                    Death = (DateTime)x.Element("death"),
                                    Masterpieces = x.Element("masterpieces")
                                                    .Elements("title")
                                                    .Select(title => title.Value)
                                                    .ToArray()
                                }) ;
            return novelists.ToArray();

        }
    }
}



