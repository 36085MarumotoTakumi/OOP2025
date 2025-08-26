using System.Text.RegularExpressions;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            lines[3] = Regex.Replace(lines[3], @"\s*v4.0\s*", "v5.0");
            File.WriteAllLines("sampleChange.txt", lines);
        }
    }
}
