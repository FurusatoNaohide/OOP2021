﻿using System;
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
            Console.WriteLine("{0} {1}", sports.Name, sports.Teammembers);
            */
            foreach (var sport in sports)
            {
                var xname = sport.Element("name");
                Console.WriteLine(xname.Value);
                
            }
            
        }
    }
}
