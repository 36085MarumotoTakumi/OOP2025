using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TextFileProcessorDI {
    public class LineToHalfNumberService : ITextFileService {
        private string[]? _half;
        
        public void Execute(string line) {
            string half = new string(line.Select(x=>('０'<=x&&x<='９')?(char)(x-'０'+'0'):x).ToArray()
                );
            Console.WriteLine(half);
        }

        public void Initialize(string name) {
            
        }

        public void Terminate() {
            
        }
    }
}
