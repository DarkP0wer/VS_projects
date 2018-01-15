using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigIntMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(var i = 0; i < textBox_ab.Lines.Length; i++)
                textBox_result.Text += (new BigInt(textBox_ab.Lines[i]) * new BigInt(textBox_dc.Lines[i])).Val+"\r\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ab.Text = "1685287499328328297814655639278583667919355849391453456921116729";
            textBox_dc.Text = "7114192848577754587969744626558571536728983167954552999895348492";
        }
    }
}
