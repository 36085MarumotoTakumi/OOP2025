using System.ComponentModel.DataAnnotations;

namespace Section04 {
    internal class Program {
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };
            //IEnumerable<string> query = cities.Reverse(s=>);
            //.OrderBy(s => s[0]);
            //.Where(s => s.Length <= 5)//条件にあったものを抽出
            //.Select(s => s.ToLower());//別オブジェクトへ変換

            var query = cities.Where(s => s.Length <= 5).ToArray();    //- query変数に代入
            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");

            cities[0] = "Osaka";            //- cities[0]を変更 
            foreach (var item in query) {   //- 再度、queryの内容を取り出す
                Console.WriteLine(item);
            }
        }
    }
}
