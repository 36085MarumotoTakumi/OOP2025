using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01 {

    public class Student {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }

        
        public Student(string name, string subject, int score) {
            Name = name;
            Subject = subject;
            Score = score;
        }
    }
}

