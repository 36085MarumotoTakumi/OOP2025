using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth(int year, int month) {
        //5.1.1
        public int Year { get; init; } = year;
        public int Month { get; init; } = month;
        //5.1.2
        public bool Is21Century => 2001 <= Year && Year <= 2100;
        //5.1.3※未完成
        public YearMonth AddOneMonth() {
            if (Month<13) {
                return new YearMonth(,);
            } else {
                return new YearMonth(,);
            }
        }
        //5.1.4※未完成
        public override string ToString() =>

    }
}
