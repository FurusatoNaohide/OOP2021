using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                var uc = char.ToUpper(c); 
                if('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            //Aから並べ替えて出力
            foreach (var obj in dict.OrderBy(s => s.Key)) {
               Console.WriteLine("'{0}':{1}", obj.Key, obj.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char,int>();
            foreach (var c in text) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            //Aから並べ替えて出力
            //ソートされているからOrderBy()は必要ない
            foreach (var obj in dict) {
                Console.WriteLine("'{0}':{1}", obj.Key, obj.Value);
            }
        }
    }
}
