using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            IDictionary<string, int> amountsPerStore = sales.GetPerstoreSales();
            foreach (KeyValuePair<string, int> obj in amountsPerStore) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
       
        }

    }
}
