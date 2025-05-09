using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上集計クラス
    public class SalesCounter {
        private readonly List<Sale> _sales;
        //コンストラクタ   
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }
        //店舗別売上
        public IDictionary<string, int> GetPerstoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) { 
                    dict[sale.ShopName] += sale.Amount;
            }else { 
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        public static List<Sale> ReadSales(string filepath) {
            //売上データを入れるリストオブジェクトを生成    
            List<Sale> sales = new List<Sale>();
            //ファイルを一気に読み込み
            string[] lines = File.ReadAllLines(filepath);
            //読み込んだ行数分繰り返し
            foreach (string line in lines) {
                String[] items = line.Split(',');
                //Saleオブジェクトを生成
                Sale sale = new Sale() {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;

        }
    }
}
