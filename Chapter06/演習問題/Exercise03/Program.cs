
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

        }

        private static void Exercise1(string text) {
            Console.WriteLine("空白数:" + text.Count(x => x == ' '));
        }

        private static void Exercise2(string text) {
            text = text.Replace("big", "small");
            Console.WriteLine(text);
        }
        private static void Exercise3(string text) {
            var words = text.Split(new[] { "  " }, StringSplitOptions.TrimEntries);
            StringBuilder sbtext = new StringBuilder();
            for (int i = 0; i < words.Count(); i++) {
                sbtext.Append(words[i]);
            }
            Console.WriteLine(sbtext);
        }

        private static void Exercise4(string text) {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Count());
        }

        private static void Exercise5(string text) {
            var fwords = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < fwords.Count(); i++) {
                if (fwords[i].Length <= 4) {
                    Console.WriteLine(fwords[i]);
                }
            }
        }
    }
}
