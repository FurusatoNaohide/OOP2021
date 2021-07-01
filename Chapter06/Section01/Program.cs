using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages).ToString("#,0") + "ページ");
            Console.WriteLine("最も価格が高い本は" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("最も価格が安い本は" + books.Min(x => x.Price).ToString("#,0") + "円");
            //500円以上の本は何冊 ※Count(条件式)
            Console.WriteLine("500円以上の本は" + books.Count(x => 500 <= x.Price).ToString("#,0") + "冊");

            //本のタイトルに「物語」が含まれている冊数
            Console.WriteLine("「物語」が含まれているいる本は" + books.Count(x => x.Title.Contains("物語")) + "冊");

            //本のタイトルに「物語」が含まれている本の一覧 参考:P90 ForEachメソッド         
            var book =  books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach (var bk in book) {
                Console.WriteLine(bk.Title);
            }
            //books.Where(x => x.Title.Contains("物語")).ToList().ForEach(s => Console.WriteLine(s.Title));

            Console.WriteLine();

            //高額書籍ベスト3 Take(3) 条件を満たす要素を3個取得
            var bookData = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var bk in bookData) {
                Console.WriteLine(bk.Title + ":" + bk.Price + "円");
            }
            //books.OrderByDescending(x => x.Price).Take(3).ToList().ForEach(s => Console.WriteLine(s.Title + ":" + s.Price + "円"));
            Console.WriteLine();

            var titles =  books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
