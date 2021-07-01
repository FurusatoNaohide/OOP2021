using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region テスト用ドライバ
            //6.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            //6.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            //6.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            //6.1.4
            Exercise1_4(numbers);
            Console.WriteLine("-----");

            //6.1.5
            Exercise1_5(numbers);
            #endregion
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            //要素数-2 最後2つ以外の要素数をSkip
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip)){
                Console.WriteLine(n);
            }
               
        }

        private static void Exercise1_3(int[] numbers) {
            numbers.Select(n => n.ToString()).ToList().ForEach(s => Console.WriteLine(s));
            /*
            var strs = numbers.Select(n => n.ToString());
            foreach (var str in strs) {
                Console.WriteLine(str);
            }
            */
        }

        private static void Exercise1_4(int[] numbers) {
            numbers.OrderBy(n => n).Take(3).ToList().ForEach(s => Console.WriteLine(s));
            /*
            foreach (var n in numbers.OrderBy(n => n).Take(3)) {
                Console.WriteLine(n);
            }
            */
        }

        private static void Exercise1_5(int[] numbers) {
            Console.WriteLine(numbers.Distinct().Count(n => n > 10));
        }
    }
}
