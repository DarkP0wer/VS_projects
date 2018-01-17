using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Wpf_Tranning_1
{
    class SomeClass
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public BitmapImage Image { get; set; }


        public SomeClass(string name, string path, BitmapImage image)
        {
            this.Name = name;
            this.Path = path;
            this.Image = image;
        }
    }
}
