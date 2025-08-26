using System.Text;
using System.Text.RegularExpressions;

namespace Exercise05 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.html");
            var sb = new StringBuilder();
            foreach (var line in lines) {
                var s = Regex.Replace(line, @"<(!?|/?)\w+", x => x.Value.ToLower());
                sb.AppendLine(s);
            }
            File.WriteAllText("sampleOut.html",sb.ToString());
        }
    }
}
