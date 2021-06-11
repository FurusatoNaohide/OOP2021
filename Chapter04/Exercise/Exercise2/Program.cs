using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");
            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-----");
            //4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                //暗黙的にYearMonthのTostring()が呼ばれている
                Console.WriteLine(ym);
            }
        }
        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                //21世紀があればforeachの途中で抜ける
                if(ym.Is21Century) {
                    return ym;
                }
            }
            //21世紀のオブジェクトが存在しなかった
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);
            //yearmonthの値がnullではなかったらデータを表示string型に直す
            var s = yearmonth != null ? yearmonth.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            //ラムダ式 コレクション.Select(一件分 => 加工処理)
            var ymc = ymCollection.Select(s => s.AddOneMonth()).ToArray();
            foreach (var ym in ymc) {
                Console.WriteLine(ym);
            }
        }
    }
}
