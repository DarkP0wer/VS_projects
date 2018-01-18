using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Media.Imaging;

namespace Wpf_Tranning_1
{
    static class GetImages
    {
        private static bool Contains(string who, params string[] what)
        {
            foreach(var it in what)
                if (it == who)
                    return true;

            return false;
        }


        public static List<Img> FromDir(string dir)
        {
            var res = new List<Img>();

            foreach (string s1 in Directory.GetFiles(dir, "*.??g"))
            {
                try
                {
                    var extension = Path.GetExtension(s1);

                    if (!Contains(extension, ".png", ".jpg"))
                        continue;


                    res.Add(new Img(Path.GetFileName(s1).Replace(extension, ""), s1, new BitmapImage(new Uri(s1))));
                }
                catch { }
            }

            return res;
        }
    }
}
