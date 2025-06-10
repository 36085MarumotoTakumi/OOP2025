

using System.Security.Cryptography;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.3");
            Exercise3(ymCollection);

            Console.WriteLine("5.2.4");
            Exercise4(ymCollection);


            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise3(YearMonth[] ymCollection) {

            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {
                    Console.WriteLine("21世紀");
                } else {
                    Console.WriteLine("21世紀ではない");
                }
            }
        }
        private static void Exercise4(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym is null) {
                    Console.WriteLine("21世紀のデータはありません");
                    break;
                } else if (ym.Is21Century) {
                    Console.WriteLine(ym + "は21世紀です");
                    break;
                }
            }
        }

        private static void Exercise5(YearMonth[] ymCollection) {

            var array = ymCollection.Select(x => x.AddOneMonth())
                .OrderBy(x => x.Year)
                .ThenBy(z => z.Month);
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
