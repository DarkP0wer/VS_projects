using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGS
{
    //Euclid aloritm using for calculate greatest commn divisor.
    public static class Euclid
    {
        public static int NOD(int a, int b)
        {
            if (b == 0) return a;

            return NOD(b, a % b);
        }


        public static XYD ExtendedNOD(int a, int b)
        {
            if (b == 0) return new XYD(1, 0, a);

            var xyd = ExtendedNOD(b, a % b);
            return new XYD(xyd.Y, xyd.X - (a / b) * xyd.Y, xyd.D);
        }

        //d = ax + by
        public class XYD
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int D { get; set; }

            public XYD(int x, int y, int d)
            {
                this.X = x;
                this.Y = y;
                this.D = d;
            }

            public override string ToString()
            {
                return $"X = {X}; Y = {Y}; D = {D}";
            }
        }
    }
}
