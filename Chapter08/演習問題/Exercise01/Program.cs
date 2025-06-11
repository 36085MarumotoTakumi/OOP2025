
using System.Diagnostics.Metrics;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();

            Exercise2(text);

        }

        private static void Exercise1(string text) {
            var dict = new SortedDictionary<char, int>();

            foreach (var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            for (char c = 'A'; c <= 'Z'; c++) {
                Console.WriteLine($"{c}: {(dict.ContainsKey(c) ? dict[c] : 0)}");
            }
        }



        private static void Exercise2(string text) {

        }
    }
}
