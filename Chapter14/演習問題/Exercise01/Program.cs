

using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Exercise01 {
    internal class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("^^");
            Console.ReadLine();
            using (var reader = new System.IO.StreamReader("./走れメロス.txt")) {
                var elapsed = await reader.ReadToEndAsync();
                Console.WriteLine(elapsed);
            }
        }
      
    }
}
