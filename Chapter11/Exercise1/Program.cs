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
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");
            
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach (var xnovelist in xelements)
            {
                var xname = xnovelist.Element("name");
                var members = xnovelist.Element("teammembers");
                Console.WriteLine("{0} {1}", xname.Value, int.Parse(members.Value));
            }

        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                .OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var xnovelist in xelements)
            {
                var xname = xnovelist.Element("name");
                Console.WriteLine(xname.Value);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
        }
    }
}
