using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGS
{
    //Primality aloritm using for check is number primality.
    class Primality
    {
        public static bool WithKarmicleNumbers(int n)
        {
            var a = new Random().Next(1, n - 1);

            if (Math.Pow(a, n - 1) % n == 1) // x ≡ 1 (mod n)
                return true;
            else
                return false;
        }
    }
}
