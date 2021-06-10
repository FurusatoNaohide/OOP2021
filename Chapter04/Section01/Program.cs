using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            /*リスト4.8
                var person = new Person {
                Name = "新井遥菜",
                Birthday = new DateTime(1995, 11, 23),
                PhoneNumber = "012-3456-7890",
            };*/


            //リスト 4.25
            /*var list = new List<int> { 10, 20, 30, 40, };
            var key = 50;
            //条件演算子・参考演算子（? 1 : 0）1←true 0←false
            var num = list.Contains(key) ? 1 : 0;
            Console.WriteLine(num);*/


            //リスト 4.27
            /*string code = "12345";
            //null合体演算子（??）
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);*/


            //リスト4.28
            //var ret = GetProductA();


            /*int count = 0;
            Console.WriteLine($"後置：{count++}");
            Console.WriteLine($"前置：{++count}");*/


            //リスト4.43
            /*var str = "12a3";

            //int height;
            if (int.TryParse(str, out var height)) {
                Console.WriteLine(height);
            } else {
                Console.WriteLine("変換できません");
            }*/


            //リスト 4.44
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if(product.Name == "") {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できた時の処理
                Console.WriteLine("productが取得できた");
            }
        }

        //スタブ
        private static object DefaultMessage() {
            return "Default Message";
        }
        private static object GetMessage(object code) {
            return code;
        }


        private static Product GetProductA() {
            Sale sale = new Sale();
            
            return sale?.Product; //null条件演算子 nullの場合アクセスしない
        }
    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
