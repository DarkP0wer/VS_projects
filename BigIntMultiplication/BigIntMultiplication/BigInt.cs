using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIntMultiplication
{
    public class BigInt
    {
        public string Val { get; set; }


        public BigInt(string str)
        {
            Val = str;
        }


        public static BigInt Multiplication(BigInt ab, BigInt cd)
        {
            SameLength(ref ab, ref cd);

            var res = new BigInt("");
            var n = ab.Val.Length;

            if (n > 3)
            {
                var a = new BigInt(ab.Val.Substring(0, n / 2));
                var b = new BigInt(ab.Val.Substring(n / 2));
                var c = new BigInt(cd.Val.Substring(0, n / 2));
                var d = new BigInt(cd.Val.Substring(n / 2));

                var ac = Multiplication(a, c);
                var bd = Multiplication(b, d);
                var ad_bc = Substraction(Substraction(Multiplication(Addition(a, b), Addition(c, d)), ac), bd);

                res = Addition(Addition(GiveZeros(ac, n), GiveZeros(ad_bc, n / 2)), bd);
            }
            else
            {
                res = new BigInt((Convert.ToInt32(ab.Val + "") * Convert.ToInt32(cd.Val + "")).ToString());
            }

            return res;
        }


        public static BigInt GiveZeros(BigInt str, int count, bool to_start = false)
        {
            if (to_start)
                for (var i = 0; i < count; i++)
                    str.Val = "0" + str.Val;
            else
                for (var i = 0; i < count; i++)
                    str.Val += "0";
            return str;
        }


        public static BigInt Addition(BigInt sa, BigInt sb)
        {
            var res = new BigInt("");
            var sa_neg = sa.Val.IndexOf("-") == -1 ? false : true;
            var sb_neg = sb.Val.IndexOf("-") == -1 ? false : true;

            sa = new BigInt(sa.Val.Replace("-", ""));
            sb = new BigInt(sb.Val.Replace("-", ""));

            if (sa_neg && sb_neg)         //-a + -b   <==>    -(a + b)
                return new BigInt("-" + Addition(sa, sb).Val);
            else if (sa_neg && !sb_neg)   //-a + b    <==>    b - a
                return Substraction(sb, sa);
            else if (!sa_neg && sb_neg)   //a + -b    <==>    a - b
                return Substraction(sa, sb);


            SameLength(ref sa, ref sb);

            var i = sa.Val.Length - 1;
            var c = 0;

            while (i >= 0)
            {
                var int_a_i = Convert.ToInt32(sa.Val[i] + "");
                var int_b_i = Convert.ToInt32(sb.Val[i] + "");
                var int_r_i = int_a_i + int_b_i + c;
                if (int_r_i > 9)
                {
                    c = int_r_i / 10;
                    int_r_i = int_r_i % 10;
                }
                else c = 0;

                res.Val = int_r_i + res.Val;
                i--;
            }

            if (c > 0)
            {
                res.Val = c + res.Val;
            }

            return res;
        }


        public static BigInt Substraction(BigInt sa, BigInt sb)
        {
            var sa_neg = sa.Val.IndexOf("-") == -1 ? false : true;
            var sb_neg = sb.Val.IndexOf("-") == -1 ? false : true;

            sa = new BigInt(sa.Val.Replace("-", ""));
            sb = new BigInt(sb.Val.Replace("-", ""));

            if (sa_neg && sb_neg)               //b - a     <==> -a - -b
                return Substraction(sb, sa);
            else if (sa_neg && !sb_neg)         //-(a + b)  <==> -a - b
                return new BigInt("-" + Addition(sa, sb).Val);
            else if (!sa_neg && sb_neg)         //a + b     <==> a - -b
                return Addition(sa, sb);

            var res = new BigInt("");

            SameLength(ref sa, ref sb);

            var i = sa.Val.Length - 1;
            var c = 0;

            while (i >= 0)
            {
                var ia_i = Convert.ToInt32(sa.Val[i] + "");
                var ib_i = Convert.ToInt32(sb.Val[i] + "");

                var ir_i = (ia_i - c) - ib_i;
                if (ir_i < 0)
                {
                    ir_i = (ia_i - c) + 10 - ib_i;
                    c = 1;
                }
                else c = 0;

                res.Val = ir_i + res.Val;
                i--;
            }

            if (c > 0)
            {
                var m = new BigInt("1");
                m = GiveZeros(m, res.Val.Length);
                res = new BigInt("-" + Substraction(m, res).Val);
            }

            return res;
        }


        public static BigInt operator * (BigInt ab, BigInt cd)
        {
            SameLength(ref ab, ref cd);

            var res = new BigInt("");
            var n = ab.Val.Length;

            if (n > 3)
            {
                var a = new BigInt(ab.Val.Substring(0, n / 2));
                var b = new BigInt(ab.Val.Substring(n / 2));
                var c = new BigInt(cd.Val.Substring(0, n / 2));
                var d = new BigInt(cd.Val.Substring(n / 2));

                var ac = a * c;
                var bd = b * d;
                var ad_bc = (a + b) * (c + d) - ac - bd;

                res = (GiveZeros(ac, n) + GiveZeros(ad_bc, n / 2)) + bd;
            }
            else
            {
                res = new BigInt((Convert.ToInt32(ab.Val + "") * Convert.ToInt32(cd.Val + "")).ToString());
            }

            return res;
        }


        public static BigInt operator + (BigInt sa, BigInt sb)
        {
            var res = new BigInt("");
            var sa_neg = sa.Val.IndexOf("-") == -1 ? false : true;
            var sb_neg = sb.Val.IndexOf("-") == -1 ? false : true;

            sa = new BigInt(sa.Val.Replace("-", ""));
            sb = new BigInt(sb.Val.Replace("-", ""));

            if (sa_neg && sb_neg)         //-a + -b   <==>    -(a + b)
                return new BigInt("-" + (sa + sb).Val);
            else if (sa_neg && !sb_neg)   //-a + b    <==>    b - a
                return (sb - sa);
            else if (!sa_neg && sb_neg)   //a + -b    <==>    a - b
                return (sa - sb);


            SameLength(ref sa, ref sb);

            var i = sa.Val.Length - 1;
            var c = 0;

            while (i >= 0)
            {
                var int_a_i = Convert.ToInt32(sa.Val[i] + "");
                var int_b_i = Convert.ToInt32(sb.Val[i] + "");
                var int_r_i = int_a_i + int_b_i + c;
                if (int_r_i > 9)
                {
                    c = int_r_i / 10;
                    int_r_i = int_r_i % 10;
                }
                else c = 0;

                res.Val = int_r_i + res.Val;
                i--;
            }

            if (c > 0)
            {
                res.Val = c + res.Val;
            }

            return res;
        }


        public static BigInt operator - (BigInt sa, BigInt sb)
        {
            var sa_neg = sa.Val.IndexOf("-") == -1 ? false : true;
            var sb_neg = sb.Val.IndexOf("-") == -1 ? false : true;

            sa = new BigInt(sa.Val.Replace("-", ""));
            sb = new BigInt(sb.Val.Replace("-", ""));

            if (sa_neg && sb_neg)               //b - a     <==> -a - -b
                return (sb - sa);
            else if (sa_neg && !sb_neg)         //-(a + b)  <==> -a - b
                return new BigInt("-" + (sa + sb).Val);
            else if (!sa_neg && sb_neg)         //a + b     <==> a - -b
                return (sa + sb);

            var res = new BigInt("");

            SameLength(ref sa, ref sb);

            var i = sa.Val.Length - 1;
            var c = 0;

            while (i >= 0)
            {
                var ia_i = Convert.ToInt32(sa.Val[i] + "");
                var ib_i = Convert.ToInt32(sb.Val[i] + "");

                var ir_i = (ia_i - c) - ib_i;
                if (ir_i < 0)
                {
                    ir_i = (ia_i - c) + 10 - ib_i;
                    c = 1;
                }
                else c = 0;

                res.Val = ir_i + res.Val;
                i--;
            }

            if (c > 0)
            {
                var m = new BigInt("1");
                m = GiveZeros(m, res.Val.Length);
                res = new BigInt("-" + Substraction(m, res).Val);
            }

            return res;
        }


        private static bool deg_of_2(ulong x)
        {
            return (x <= 0) ? false : (x & (x - 1)) == 0;
        }


        private static void SameLength(ref BigInt a, ref BigInt b)
        {
            var a_Length = a.Val.Replace("-", "").Length;
            var b_Length = b.Val.Replace("-", "").Length;

            if (a_Length == b_Length)
                goto exit;

            if (a_Length > b_Length)
                b = GiveZeros(b, a_Length - b_Length, true);
            else
                a = GiveZeros(a, b_Length - a_Length, true);

            exit:
            while (!deg_of_2((ulong)a.Val.Length))
            {
                b = GiveZeros(b, 1, true);
                a = GiveZeros(a, 1, true);
            }
        }
    }
}