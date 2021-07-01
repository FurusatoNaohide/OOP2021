using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        ////******** Programクラスの上に配置
        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
        ////********************************
        static void Main(string[] args) {
            ////******** Mainメソッドの中にコピー
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            #region テスト用ドライバ
            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            ////********************************
            #endregion
        }

        private static void Exercise2_1(List<Book> books) {
            //Whereはすべてのデータを比較するから非効率
            //books.Where(x => x.Title == "ワンダフル・C#ライフ").ToList().ForEach(s => Console.WriteLine(s.Price + " " + s.Pages));

            var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            if(book != null) {
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
            }
            
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(s => s.Title.Contains("C#")));
        }

        private static void Exercise2_3(List<Book> books) {
            Console.WriteLine(books.Where(s => s.Title.Contains("C#")).Average(n => n.Pages));
        }

        private static void Exercise2_4(List<Book> books) {
            //Console.WriteLine(books.FirstOrDefault(s => s.Price >= 4000).Title);
            //FirstOfDefault()は対象がない場合、nullを返す
            
            var book = books.FirstOrDefault(s => s.Price >= 4000);
            if (book != null) {
                Console.WriteLine(book.Title);
            }
            
        }

        private static void Exercise2_5(List<Book> books) {
            Console.WriteLine(books.Where(s => s.Price < 4000).Max(s => s.Pages));
        }

        private static void Exercise2_6(List<Book> books) {
            books.Where(s => s.Pages >= 400).OrderByDescending(s => s.Price).ToList().ForEach(s => Console.WriteLine(s.Title + " " + s.Price));
            /*
            var Books = books.Where(s => s.Pages >= 400).OrderByDescending(s => s.Price);
            foreach (var book in Books) {
                Console.WriteLine("{0} {1}",book.Title, book.Price.ToString("#,0"));
            }
            */
        }

        private static void Exercise2_7(List<Book> books) {
            books.Where(s => s.Title.Contains("C#") && s.Pages <= 500).ToList().ForEach(s => Console.WriteLine(s.Title));
            /*
            var Books = books.Where(s => s.Title.Contains("C#") && s.Pages <= 500);
            foreach (var book in Books) {
                Console.WriteLine(book.Title);
            }
            */
        }
    }
}
