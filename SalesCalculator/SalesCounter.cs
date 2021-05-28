﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    class SalesCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //List 2-15
        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(String filePath) {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //List 2-17
        //店舗別の売り上げを求める
        public IDictionary<string,int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    //既にコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
