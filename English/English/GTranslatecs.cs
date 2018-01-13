using System;
using System.Text;
using WMPLib;

namespace English
{
    static class GoogleTranslate
    {
        public static string[] voice_url = new string[2];
        static WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static void Speak(bool is_from)
        {
            player.URL = voice_url[Convert.ToInt32(!is_from)];
            player.controls.play();
        }


        public static string TKK()
        {
            uint a = 561666268;
            uint b = 1526272306;
            return "406398." + (a + b);
        }


        public static uint charCodeAt(string str, int index)
        {
            string chr = str.Substring(index, 1);
            byte[] bytes = Encoding.GetEncoding(12001).GetBytes(chr);

            return Convert.ToUInt32(BitConverter.ToString(bytes).Replace("-", string.Empty), 16);
        }


        public static string str_pad(string to, int n, string what)
        {
            for (var i = to.Length; to.Length < n; i++)
                to = what + to;

            return to;
        }


        public static uint shr32(uint x, uint bits)
        {
            if (bits <= 0)
            {
                return x;
            }
            if (bits >= 32)
            {
                return 0;
            }

            var bin = Convert.ToString(x, 2);
            var l = bin.Length;

            if (l > 32)
            {
                bin = bin.Substring(l - 32, 32);
            }
            else if (l < 32)
            {
                bin = str_pad(bin, 32, "0");
            }

            return Convert.ToUInt32(str_pad(bin.Substring(0, (int)(32 - bits)), 32, "0"), 2);
        }


        public static string RL(string a, string b)
        {
            for (var c = 0; c < b.Length - 2; c += 3)
            {
                uint d = b[c + 2];

                d = (d >= 'a' ? charCodeAt((char)d + "", 0) - 87 : Convert.ToUInt32("" + Convert.ToChar(d)));
                d = (b[c + 1] == '+' ?
                    shr32(Convert.ToUInt32(a), d) :
                    Convert.ToUInt32(a) << (byte)d);
                a = Convert.ToString(b[c] == '+' ? (Convert.ToUInt32(a) + Convert.ToUInt32(d) & 4294967295) : Convert.ToUInt32(a) ^ d);
            }

            return a;
        }


        public static string TL(string a)
        {
            var tkk = TKK().Split('.');
            var b = tkk[0];
            uint[] d = new uint[1];
            var e = 0;

            for (var f = 0; f < a.Length; f++)
            {
                var g = charCodeAt(a, f);

                if (128 > g)
                {
                    if (e == d.Length)
                        Array.Resize(ref d, d.Length + 1);

                    d[e++] = g;
                }
                else
                {
                    if (2048 > g)
                    {
                        if (e == d.Length)
                            Array.Resize(ref d, d.Length + 1);

                        d[e++] = g >> 6 | 192;
                    }
                    else
                    {
                        if (55296 == (g & 64512) && f + 1 < a.Length && 56320 == (charCodeAt(a, f + 1) & 64512))
                        {
                            g = (char)(65536 + ((g & 1023) << 10) + (charCodeAt(a, ++f) & 1023));

                            if (e == d.Length)
                                Array.Resize(ref d, d.Length + 1);

                            d[e++] = g >> 18 | 240;

                            if (e == d.Length)
                                Array.Resize(ref d, d.Length + 1);

                            d[e++] = g >> 12 & 63 | 128;
                        }
                        else
                        {
                            if (e == d.Length)
                                Array.Resize(ref d, d.Length + 1);

                            d[e++] = g >> 12 | 224;

                            if (e == d.Length)
                                Array.Resize(ref d, d.Length + 1);

                            d[e++] = g >> 6 & 63 | 128;
                        }
                    }

                    if (e == d.Length)
                        Array.Resize(ref d, d.Length + 1);

                    d[e++] = g & 63 | 128;
                }
            }

            a = b;

            for (e = 0; e < d.Length; e++)
            {
                a = Convert.ToString(Convert.ToUInt32(a) + d[e]);
                a = RL(a, "+-a^+6");

            }

            a = RL(a, "+-3^+b+-f");
            a = Convert.ToString(Convert.ToUInt32(a) ^ Convert.ToUInt32(tkk[1]));

            if (0 > Convert.ToUInt32(a))
            {
                a = Convert.ToString((Convert.ToUInt32(a) & 2147483647) + 2147483648);
            }

            a = Convert.ToString(Convert.ToUInt32(a) % Math.Pow(10, 6));

            return a + "." + (Convert.ToUInt32(a) ^ Convert.ToUInt32(b));
        }
    }


    
}
