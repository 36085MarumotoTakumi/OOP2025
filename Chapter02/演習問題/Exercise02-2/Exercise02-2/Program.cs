using System.Diagnostics.Metrics;

namespace Exercise022 {
    internal class Program {
        static void Main(string[] args) {



            Console.WriteLine("1:ヤードからメートル");
            Console.WriteLine("2:メートルからヤード");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("はじめの数値:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("おわりの数値:");
            int end = int.Parse(Console.ReadLine());

            if (a == 1) {
                //メートルからヤードへの変換
                for (int yard = start; yard <= end; yard++) {
                    double meter = YardConverter.ToYard(yard);
                    Console.WriteLine($"{yard}yard={meter:0.0000}m");
                }
            }
            if (a == 2) {
                //ヤードからメートルの変換
                for (int meter = start; meter <= end; meter++) {
                    double yard = YardConverter.FromYard(meter);
                    Console.WriteLine($"{meter}m={yard:0.0000}yard");
                }
            }
        }
    }
}

