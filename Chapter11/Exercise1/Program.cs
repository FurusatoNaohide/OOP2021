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
            Exercise1_1(file);
            Console.WriteLine("--11_1_1-----");

            Exercise1_2(file);
            Console.WriteLine("--11_1_2-----");

            Exercise1_3(file);
            Console.WriteLine("--11_1_3-----");
            
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements();
            /*
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
                                .OrderBy(x => (string)x.Element("firstplayed"));
            /*
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 FirstPlayed = x.Element("firstplayed").Value,
                                 Name = x.Element("name").Attribute("kanji").Value
                                 
                             }).OrderBy(x => int.Parse(x.FirstPlayed));
            */

            foreach (var sport in sports)
            {
                var xname = sport.Element("name").Attribute("kanji");
                Console.WriteLine(xname.Value);

                //Console.WriteLine("{0} {1}", sport.Name, sport.FirstAttribute);
            }
        }

        private static void Exercise1_3(string file)
        {
            
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                .OrderByDescending(x => (string)x.Element("teammembers")).Take(1);
            foreach (var sport in sports)
            {
                var xname = sport.Element("name");
                Console.WriteLine(xname.Value);
            }
            
        }
    }
}
