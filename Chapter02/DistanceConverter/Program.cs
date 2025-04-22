using System.Diagnostics.Metrics;

namespace DistanceConverter {
    internal class Program {
        // コマンドライン引数で指定されたフィートとメートルの対応表を出力する
        static void Main(string[] args) {

            FeetComverter Comverter = new FeetComverter();

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(start, end);
            } else {
                PrintMeterToFeet(start, end);
            }
            //フィートからメートルへの変換
            static void PrintFeetToMeterList(int start, int end) {
                FeetComverter Converter = new FeetComverter();
                for (int feet = start; feet <= end; feet++) {
                    double meter = Converter.ToMeter(feet);
                    Console.WriteLine($"{feet}ft={meter:0.0000}m");
                }
            }
            //メートルからフィートへの変換
            static void PrintMeterToFeet(int start, int end) {
                FeetComverter Converter = new FeetComverter();
                for (int meter = start; meter <= end; meter++) {
                    double feet = Converter.FromMeter(meter);
                    Console.WriteLine($"{meter}m={feet:0.0000}ft");
                }
            }
        }
    }

}
