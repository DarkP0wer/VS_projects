using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGS
{
    class Sort
    {
        //Merge Sort
        public static List<int> MergeSort(List<int> a)
        {
            return a.Count > 1 ?
                    Merge(  MergeSort(a.GetRange(0, a.Count / 2)),
                            MergeSort(a.GetRange(a.Count / 2, a.Count-a.Count/2))
                         ) :
                    a;
        }


        public static List<int> Merge(List<int> x, List<int> y)
        {
            if (x.Count == 0) return y;
            else if (y.Count == 0) return x;
            else if (x[0] <= y[0])
            {
                var t = Merge(x.GetRange(1, x.Count - 1), y);
                t.Insert(0, x[0]);
                return t;
            }
            else
            {
                var t = Merge(x, y.GetRange(1, y.Count - 1));
                t.Insert(0, y[0]);
                return t;
            }
        }


        public static void QuickSort(ref List<int> a, int from, int to)
        {
            int x, i, j, temp;

            if (from >= to) return;

            i = from;
            j = to;
            x = a[(from + to) / 2];

            while(i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if(i<=j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            QuickSort(ref a, from, j);
            QuickSort(ref a, i, to);
        }
    }
}
