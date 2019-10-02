using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace English
{
    public partial class Form1 : Form
    {
        #region GTranslate Tab
        private void comboBox_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_from.SelectedIndex > -1 && comboBox_to.SelectedIndex > -1)
                PrepareToTranslate();
        }


        private void comboBox_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_from.SelectedIndex > -1 && comboBox_to.SelectedIndex > -1)
                PrepareToTranslate();
        }


        private void checkBox_ao_CheckedChanged(object sender, EventArgs e)
        {
            textBox_ao.Visible = checkBox_ao.Checked;
        }


        private void button_r_Click(object sender, EventArgs e)
        {
            var d = comboBox_from.SelectedIndex;

            comboBox_from.SelectedIndex = comboBox_to.SelectedIndex;
            comboBox_to.SelectedIndex = d;
        }


        void PrepareToTranslate()
        {
            var q = textBox_text.Text;
            var sl = comboBox_from.SelectedItem.ToString();
            var tl = comboBox_to.SelectedItem.ToString();

            new Thread(() => Translate(q, sl, tl, textBox_trans, false, this.checkBox_ao, this.textBox_ao)).Start();
        }


        private void button_translate_Click(object sender, EventArgs e)
        {
            PrepareToTranslate();
        }


        private void textBox_text_TextChanged(object sender, EventArgs e)
        {
            timer_translate_wait.Enabled = false;
            timer_translate_wait.Enabled = true;
        }


        private void timer_translate_wait_Tick(object sender, EventArgs e)
        {
            PrepareToTranslate();
            timer_translate_wait.Enabled = false;
        }


        private void button_speak_from_Click(object sender, EventArgs e)
        {
            GoogleTranslate.Speak(true);
        }


        private void button_speak_to_Click(object sender, EventArgs e)
        {
            GoogleTranslate.Speak(false);
        }

#endregion
    }
}
