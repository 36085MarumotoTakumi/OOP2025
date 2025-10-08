using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    internal class ImperialUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit>() {
            new MetricUnit{Name ="in",Coefficient= 1,},
            new MetricUnit{Name ="ft",Coefficient= 12,},
            new MetricUnit{Name ="yd",Coefficient= 12 * 3,},
            new MetricUnit{Name ="ml",Coefficient= 12 * 3* 1760,},
        };
        public static ICollection<MetricUnit> Units { get => units; }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">変換元の単位</param>
        /// <param name="value">変換する値</param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value) {
            return (value*unit.Coefficient) / 25.4 /Coefficient;
        }
    }
}
