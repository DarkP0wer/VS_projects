using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGS
{
    //Euclid aloritm using for calculat greatest commn divisor.
    public static class Euclid
    {
        public static int NOD(int a, int b)
        {
            if (b == 0) return a;

            return NOD(b, a % b);
        }
    }
}
