using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var db = new BooksDbContext())
            {
                db.Database.Log = sql => { Debug.Write(sql); };
                var count = db.Books.Count();
                Console.WriteLine(count);  
            }
            */
            //データの追加
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();

            //演習13章
            Console.WriteLine("#1.1");
            //Exercise13_1_1();

            Console.WriteLine("#1.1.2");
            //Exercise13_1_2();

            Console.WriteLine("#1.2");
            Exercise13_2();

            Console.WriteLine("#1.3");
            Exercise13_3();

            Console.WriteLine("#1.4");
            Exercise13_4();

            Console.WriteLine("#1.5");
            Exercise13_5();

            //Exercise13_6(); //コンソールから書籍情報入力 未完成

            Console.ReadLine(); //F5で実行してもすぐコンソール画面が消えないようにする

            #region// 13-10 高度なクエリ
            /*
            using (var db = new BooksDbContext())
            {

                //書籍が二冊以上の著者を取得する
                var authors = db.Authors.Where(a => a.Books.Count() >= 2);
                foreach (var author1 in authors)
                {
                    Console.WriteLine($"{author1.Name} {author1.Gender}{author1.Birthday}");
                }

                //出版年、著者名の順（それぞれ昇順）に書籍を並べ替えて取得する
                var books = db.Books.OrderBy(b => b.PublishedYear)
                                    .ThenBy(b => b.Author.Name);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }

                //発行年ごとの書籍数を求める
                var groups = db.Books.GroupBy(b => b.PublishedYear)
                                    .Select(g => new
                                    {
                                        Year = g.Key,
                                        Count = g.Count()
                                    });
                foreach (var g in groups)
                {
                    Console.WriteLine($"{g.Year} {g.Count}");
                }

                //もっとも冊数の多い著者を求める
                var author2 = db.Authors.Where(a => a.Books.Count() == db.Authors.Max(x => x.Books.Count())).First();
                Console.WriteLine($"{author2.Name} {author2.Gender} {author2.Birthday}");

            }
            */
            #endregion

        }

        private static void Exercise13_6()
        {
            Console.Write("著者名：");
            var AName = Console.ReadLine();
            Console.WriteLine("生年月日");
            Console.Write("年：");
            var Year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var Month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var Date = int.Parse(Console.ReadLine());

            Console.Write("性別 M or F：");
            var AGender = Console.ReadLine();

            using (var db = new BooksDbContext())
            {
                var author = new Author
                {
                    Birthday = new DateTime(Year, Month, Date),
                    Gender = AGender,
                    Name = AName
                };

                db.Authors.Add(author);
                db.SaveChanges();
            }

            Console.Write("書籍名：");
            var BTitle = Console.ReadLine();
            Console.Write("発行年：");
            var BPublishedYear = Console.ReadLine();
            Console.Write("著者名：");
            var BName = Console.ReadLine();

            using (var db = new BooksDbContext())
            {
                var author = db.Authors.Single(a => a.Name == BName);
                var book = new Book
                {
                    Title = BTitle,
                    PublishedYear = int.Parse(BPublishedYear),
                    Author = author,
                };
                db.Books.Add(book);
                db.SaveChanges();
            }


        }

        private static void Exercise13_5()
        {
            using (var db =new BooksDbContext())
            {
                var a = db.Books.OrderByDescending(b => b.Author.Birthday).ToList();
                var query = a.GroupBy(x => x.Author.Name);
                foreach (var group in query)
                {
                    Console.WriteLine(group.Key);
                    foreach (var book in group)
                    {
                        Console.WriteLine($"{book.Title} {book.PublishedYear}");
                    }
                    Console.WriteLine();
                }

                /*解説
                var authors = db.Authors.OrderByDescending(b => b.Birthday);
                foreach (var author in authors)
                {
                    Console.WriteLine("{0} ({1:yyyy/MM})", author.Name, author.Birthday);
                    foreach (var book in author.Books)  //authorからBookクラスを参照
                    {
                        Console.WriteLine("{0} {1}",
                                book.Title, book.PublishedYear);
                    }
                    Console.WriteLine();
                }
                */
            }
        }

        private static void Exercise13_4()
        {
            using (var db = new BooksDbContext())
            {
                var datas = db.Books.OrderBy(x => x.PublishedYear).Take(3);
                foreach (var data in datas)
                {
                    Console.WriteLine($"{data.Title} {data.Author.Name}");
                    /* 解説
                    Console.WriteLine("{0} {1} {2} ({3:yyyy/MM/dd})",
                                        data.Title, data.PublishedYear, data.Author.Name, data.Author.Birthday);
                    */
                }
            }
        }

        private static void Exercise13_3()
        {
            using (var db = new BooksDbContext())
            {
                var datas = db.Books.Where(x => x.Title.Length == db.Books.Max(m => m.Title.Length));
                foreach (var data in datas)
                {
                    Console.WriteLine($"{data.Title}");
                    /* 解説
                    Console.WriteLine("{0} {1} {2} ({3:yyyy/MM/dd})",
                                        data.Title, data.PublishedYear, data.Author.Name, data.Author.Birthday);
                    */
                }
            }
        }

        private static void Exercise13_2()
        {
            using (var db = new BooksDbContext())
            {
                var datas = db.Books;
                //var datas = db.Books.OrderBy(x => x.Author.Name); //著者名ごとに並び替え(昇順)
                foreach (var data in datas)
                {
                    Console.WriteLine($"{data.Title} {data.PublishedYear} {data.Author.Name}");
                    /*解説
                    Console.WriteLine("{0} {1} {2} ({3:yyyy/MM/dd})",
                                        data.Title, data.PublishedYear, data.Author.Name, data.Author.Birthday);
                    */
                }
            }
        }

        private static void Exercise13_1_2()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);

                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
            
        }

        private static void Exercise13_1_1()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };

                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        #region "テキスト内容 P321～343"
        // List 13-12
        private static void DeleteBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        // List 13-11
        private static void UpdateBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-5
        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges();   //データベースを更新
            }
        }

        // List 13-7
        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        // List 13-8
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine(); //F5で実行後、一時停止させる
        }

        // List 13-9
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };

                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
        #endregion 
    }
}
