﻿using System;
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
            //500円以上の本は何冊
            Console.WriteLine("500円以上の本は" + books.Count(x => 500 <= x.Price).ToString("#,0") + "冊");
        }
    }
}