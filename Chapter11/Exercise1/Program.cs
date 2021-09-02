using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            var file2 = "11_2.xml";
            Console.WriteLine("--11_1_1-----");
            Exercise1_1(file);
            Console.WriteLine();
            Console.WriteLine("-------");

            Console.WriteLine("--11_1_2-----");
            Exercise1_2(file);
            Console.WriteLine();
            Console.WriteLine("-------");

            Console.WriteLine("--11_1_3-----");
            Exercise1_3(file);
            Console.WriteLine();
            Console.WriteLine("-------");

            Console.WriteLine("--11_1_4-----");
            Exercise1_4(file);
            Console.WriteLine();
            Console.WriteLine("-------");

            Console.WriteLine("--11_2-----");
            Exercise2(file2);
            Console.WriteLine();
            Console.WriteLine("-------");
        }

        
        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements();
            /*匿名クラスを用いた
            var sports = xdoc.Root.Elements()
                             .Select(x=> new { 
                                Name = x.Element("name").Value,
                                Teammembers = x.Element("teammembers").Value
                             });
            */

            foreach (var sport in sports)
            {
                
                var xname = sport.Element("name");
                var members = sport.Element("teammembers");
                Console.WriteLine("{0} {1}", xname.Value, int.Parse(members.Value));
                
                //Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }

        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                .OrderBy(x => (int)x.Element("firstplayed"));
            /*匿名クラスを用いた
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 FirstPlayed = x.Element("firstplayed").Value,
                                 Name = x.Element("name").Attribute("kanji").Value
                                 
                             }).OrderBy(x => int.Parse(x.FirstPlayed));
            */

            foreach (var sport in sports)
            {
                var xname = sport.Element("name").Attribute("kanji");
                var first = sport.Element("firstplayed");
                Console.WriteLine("{0} {1}", xname.Value,first.Value);

                //Console.WriteLine("{0} {1}", sport.Name, sport.FirstAttribute);
            }
        }

        private static void Exercise1_3(string file)
        {
            
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                .OrderByDescending(x => (int)x.Element("teammembers")).Take(1);
            /* 匿名クラスを用いた*/
            /*var sports = xdoc.Root.Elements()
                              .Select(x => new
                              {
                                  Name = x.Element("name").Value,
                                  Teammembers = x.Element("teammembers").Value

                              }).OrderByDescending(x => int.Parse(x.Teammembers)).First(); 
            Console.WriteLine("{0}", sports.Name);
            */
            foreach (var sport in sports)
            {
                var xname = sport.Element("name");
                Console.WriteLine(xname.Value);
                
            }
            
        }

        private static void Exercise1_4(string file)
        {
            var newfile = "sports.xml";//出力する新しいファイル
            //P290 リスト11.5を参考
            //追加するデータ
            var element = new XElement("ballsport",
                                new XElement("name","サッカー",new XAttribute("kanji","蹴球")),
                                new XElement("temmembers","11"),
                                new XElement("firstplayed","1863")
                                );
            var xdoc = XDocument.Load(file);//追加先のXMLファイルを読み込む
            xdoc.Root.Add(element);//追加先へ追加
            xdoc.Save(newfile);
            
        }

        private static void Exercise2(string file2)
        {
            /*完成*/
            var newfile = "11_2_bak.xml";//出力する新しいファイル
            //リスト11.27を参考 XMLファイルから
            var xdoc = XDocument.Load(file2);
            var dict = xdoc.Root.Elements()
                            .Select(x => new
                            {
                                Kanji = x.Element("kanji").Value,
                                Yomi = x.Element("yomi").Value
                            });
            //リスト11.26を参考 新しいXMLファイルを作成
            var query = dict.Select(x => new XElement("word",
                                            new XAttribute("kanji", x.Kanji),
                                            new XAttribute("yomi", x.Yomi)));
            var root = new XElement("difficultkanji", query);
            root.Save(newfile);
            
        }

    }
}
