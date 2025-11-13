using TextFileProcessor;


namespace LineCounter {
    internal class Program {

        static void Main(string[] args) {
            try {
                Console.WriteLine("ファイルパスを入力してください");
                var path = Console.ReadLine();
                TextProcessor.Run<LineCounterProcessor>(path);
            }
            catch (Exception) {
                Console.WriteLine("ファイルが見つかりません");
            }
        }
    }
}
