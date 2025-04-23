using System.Diagnostics.Metrics;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {



            Console.WriteLine("1:インチからメートル");
            Console.WriteLine("2:メートルからインチ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("はじめの数値:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("おわりの数値:");
            int end = int.Parse(Console.ReadLine());

            if (a == 1) {
                //インチからメートルへの変換
                for (int inch = start; inch <= end; inch++) {
                    double meter = InchConverter.ToMeter(inch);
                    Console.WriteLine($"{inch}inch={meter:0.0000}m");
                }
            }
            if (a == 2) {
                //メートルからインチへの変換
                for (int meter = start; meter <= end; meter++) {
                    double inch = InchConverter.FromMeter(meter);
                    Console.WriteLine($"{meter}m={inch:0.0000}inch");
                }
            }
        }
    }
}

