using System.Text.RegularExpressions;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "private List<string> result = new List<string>();";

            //bool isMatch = Regex.IsMatch(text,@"List<\w+>");

            //var regex = new Regex(@"List<\w+>");
            bool isMatch = IsPatternText(text, @"$private");
            if (isMatch) {
                Console.WriteLine("privateで始まっています");
            } else {
                Console.WriteLine("privateで始まっていせん");
            }
        }
        static bool IsPatternText(string text, string pattern) {
            return Regex.IsMatch(text,pattern);
        }
    }
}
