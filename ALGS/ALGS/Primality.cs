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

        //Algorithm for checking the primality of a number with a low probability of error.
        public static bool Primality2(int n)
        {
            var a = new List<int>();
            var k = new Random().Next(1, n - 1);
            for(var i = 0; i < k; i++)
                a.Add(new Random().Next(1, n - 1));

            var res = true;
            foreach (var item in a)
            {
                if (!(Math.Pow(item, n - 1) % n == 1)) // not(x ≡ 1 (mod n))
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
