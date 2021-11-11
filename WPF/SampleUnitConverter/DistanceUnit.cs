using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter
{
    public class DistanceUnit
    {
        public string Name { get; set; }
        public double Confficient { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }

    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit
    {
        private static List<MetricUnit> units = new List<MetricUnit>
        {
            new MetricUnit{Name = "mm", Confficient = 1},
            new MetricUnit{Name = "cm", Confficient = 10},
            new MetricUnit{Name = "m", Confficient = 10*100},
            new MetricUnit{Name = "km", Confficient = 10*100*1000},
        };
        public static ICollection<MetricUnit> Units { get { return units; }}

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromImperialUnit(ImperialUnit unit, double value)
        {
            return (value * unit.Confficient) * 25.4 / this.Confficient;
        }
    }

    //ヤード単位を表すクラス
    public class ImperialUnit : DistanceUnit
    {
        private static List<ImperialUnit> units = new List<ImperialUnit>
        {
            new ImperialUnit{Name = "in", Confficient = 1},
            new ImperialUnit{Name = "ft", Confficient = 12},
            new ImperialUnit{Name = "yd", Confficient = 12*3},
            new ImperialUnit{Name = "ml", Confficient = 12*3*1760},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value)
        {
            return (value * unit.Confficient) / 25.4 / this.Confficient;
        }
    }
}
