using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise022 {
    public class YardConverter {
        //定数 
        private const double ratio = 1.09361;
        //メートルからヤードを求める
        public static double ToYard(double feet) {
            return feet * ratio;
        }
        //ヤードからメートルを求める
        public static double FromYard(double meter) {
            return meter / ratio;
        }
    }
}
