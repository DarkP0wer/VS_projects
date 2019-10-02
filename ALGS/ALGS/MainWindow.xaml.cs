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
        

        private void button_Euclid_res_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.TryParse(this.textBox_Euclid_a.Text, out a) ? a : -1;
            int b = Int32.TryParse(this.textBox_Euclid_b.Text, out b) ? b : -1;
            var res = Euclid.NOD(a, b);
            this.textBox_Euclid_res.Text = res.ToString();
        }


        private void button_ExtendedEuclid_res_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.TryParse(this.textBox_ExtendedEuclid_a.Text, out a) ? a : -1;
            int b = Int32.TryParse(this.textBox_ExtendedEuclid_b.Text, out b) ? b : -1;
            var res = Euclid.ExtendedNOD(a, b);
            this.textBox_ExtendedEuclid_res.Text = res.ToString();
        }


        private void button_Primality_res_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.TryParse(this.textBox_Primality_a.Text, out a) ? a : -1;
            var res = Primality.WithKarmicleNumbers(a);
            this.textBox_Primality_res.Text = res.ToString();
        }


        private void textBox_NumOnly_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key < Key.D0 || e.Key > Key.D9)
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                    e.Handled = true;
        }


        private void textBox_NumOnlySpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
                if ((e.Key < Key.NumPad0 || e.Key > Key.NumPad9) && e.Key != Key.Space)
                    e.Handled = true;
        }


        private void button_Primality2_res_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.TryParse(this.textBox_Primality2_a.Text, out a) ? a : -1;
            var res = Primality.Primality2(a);
            this.textBox_Primality2_res.Text = res.ToString();
        }


        private void button_MergeSort_res_Click(object sender, RoutedEventArgs e)
        {
            var a = new List<Int32>();
            try
            {
                a = this.textBox_MergeSort_a.Text.Split(' ').ToList().Select(int.Parse).ToList();
            }
            catch
            {
                a = new List<int>() { -999, -1, -1337, -228, -404, -31337 };
            }
            var res = Sort.MergeSort(a);
            var res_str = "";
            for (var i = 0; i < res.Count; i++)
                res_str += res[i] + " ";
            res_str = res_str.Substring(0, res_str.Length - 1);
            this.textBox_MergeSort_res.Text = res_str;
        }


        private void button_QuickSort_res_Click(object sender, RoutedEventArgs e)
        {
            var a = new List<Int32>();
            try
            {
                a = this.textBox_QuickSort_a.Text.Split(' ').ToList().Select(int.Parse).ToList();
            }
            catch
            {
                a = new List<int>() { -999, -1, -1337, -228, -404, -31337 };
            }
            Sort.QuickSort(ref a, 0, a.Count-1);
            var res_str = "";
            for (var i = 0; i < a.Count; i++)
                res_str += a[i] + " ";
            res_str = res_str.Substring(0, res_str.Length - 1);
            this.textBox_QuickSort_res.Text = res_str;
        }


    }
}
