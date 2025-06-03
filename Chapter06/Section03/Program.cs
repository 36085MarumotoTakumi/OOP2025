﻿using System.Diagnostics.Tracing;
using System.Text;

namespace Section03 {
    internal class Program {
        static void Main(string[] args) {
            var sb = new StringBuilder();
            foreach (var word in GetWords()) {
                sb.Append(word);
            }
            var text=sb.ToString();
            Console.WriteLine(text);

            String str = "";
            foreach (var word in GetWords()) {
                str += word;
            }
            Console.WriteLine(str);
        }
        private static IEnumerable<object> GetWords() {
            return ["ORange","Lemon","Strawberry"];
        }
    }
}
