using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public class InchConverter {
        //定数 
        private const double ratio = 0.0254;
        //インチからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
