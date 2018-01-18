using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ALGS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.TryParse(this.textBox_a.Text, out a) ? a : -1;
            int b = Int32.TryParse(this.textBox_b.Text, out b) ? b : -1;
            //var res = Euclid.ExtendedNOD(a, b);
            //Euclid.NOD(a, b);
            var res = Primality.WithKarmicleNumbers(a);

            this.textBlock_res.Text = res.ToString();
        }
    }
}
