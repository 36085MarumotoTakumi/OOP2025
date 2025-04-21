using System.Diagnostics.Metrics;

namespace DistanceConverter {
    internal class Program {
        // コマンドライン引数で指定されたフィートとメートルの対応表を出力する
        static void Main(string[] args) {
            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);


            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(start, end, end);
            } else {
                PrintMeterToFeet(start, end, end);
            }
                static void PrintFeetToMeterList(int start, int stop, int end) {
                //フィートからメートルへの変換
                for (int feet = start; feet <= end; feet++) {
                        double meter = FeetToMeter(feet);
                        Console.WriteLine($"{feet}ft={meter:0.0000}m");
                    }
                }
            //メートルからフィートへの変換
        static void PrintMeterToFeet(int start, int stop, int end) { 
                for (int meter = start; meter <= end; meter++) {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine($"{meter}m={feet:0.0000}ft");
                }
            }
        }
        




        //フィートからメートルへの変換
        static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートへの変換
        static double MeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }

}
