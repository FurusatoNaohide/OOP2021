using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            /*var person = new Person {
                Name = "新井遥菜",
                Birthday = new DateTime(1995, 11, 23),
                PhoneNumber = "012-3456-7890",
            };*/


            /*var list = new List<int> { 10, 20, 30, 40, };
            var key = 50;
            //条件演算子・参考演算子（? 1 : 0）1←true 0←false
            var num = list.Contains(key) ? 1 : 0;
            Console.WriteLine(num);*/


            /*string code = "12345";
            //null合体演算子（??）
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);*/


            //var ret = GetProductA();


            int count = 0;
            Console.WriteLine($"後置：{count++}");
            Console.WriteLine($"前置：{++count}");
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
