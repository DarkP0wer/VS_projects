using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace English
{
    public partial class Form1 : Form
    {
        private void radioButton_checkChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var gb = rb.Parent;
            gb.BackColor = Color.Red;
            words.Where(w => w.Eng == gb.Text && w.Rus == rb.Text).ToList().ForEach(f =>
            {
                f.eng_lrn_count += 1;
                gb.BackColor = Color.Green;
                GoogleTranslate.Speak(f.Eng);
                gb.Text += $" ({f.eng_lrn_count})";
            }
            );
            gb.Enabled = false;
            new Thread(() => HideGroupBox(gb)).Start();
        }


        private void radioButton_r_checkChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var gb = rb.Parent;
            gb.BackColor = Color.Red;
            words.Where(w => w.Rus == gb.Text && w.Eng == rb.Text).ToList().ForEach(f =>
            {
                f.rus_lrn_count += 1;
                gb.BackColor = Color.Green;
                gb.Text += $" ({f.eng_lrn_count})";
                GoogleTranslate.Speak(f.Eng);
            }
            );
            gb.Enabled = false;
            new Thread(() => HideGroupBox(gb)).Start();
        }


        private void HideGroupBox(Control gb)
        {
            Thread.Sleep(300);

            Invoke(new Action(() =>
            {
                gb.Dispose();
                gb = null;
            }
            ));
        }


        void CreateTest()
        {
            var filtered_words = words.Where(x =>
                                            x.eng_lrn_count < Config.count_to_exclude_word ||
                                            x.rus_lrn_count < Config.count_to_exclude_word);
            var filtered_eng_words = filtered_words.Where(x => x.eng_lrn_count < Config.count_to_exclude_word).ToList();
            var filtered_rus_words = filtered_words.Where(x => x.rus_lrn_count < Config.count_to_exclude_word).ToList();

            filtered_words = null;

            var selected_eng_words = new List<Words>();
            var selected_rus_words = new List<Words>();
            var rnd = 0;
            var words_min = 10;
            var words_max = Config.countRowsForRetime;
            var crw = words_min + rand.Next() % (words_max - words_min + 1);
            var max_eng_count = crw < filtered_eng_words.Count ? crw : filtered_eng_words.Count;
            var max_rus_count = crw < filtered_rus_words.Count ? crw : filtered_rus_words.Count;

            for (var i = 0; i < max_eng_count; i++)
            {
                rnd = rand.Next() % filtered_eng_words.Count;
                selected_eng_words.Add(filtered_eng_words[rnd]);
                filtered_eng_words.RemoveAt(rnd);
            }

            for (var i = 0; i < max_rus_count; i++)
            {
                rnd = rand.Next() % filtered_rus_words.Count;
                selected_rus_words.Add(filtered_rus_words[rnd]);
                filtered_rus_words.RemoveAt(rnd);
            }

            CreateFormForTest(selected_eng_words, selected_rus_words);
        }


        void CreateQustuins(Form testForm, List<Words> selected_words, bool is_eng = true)
        {
            var lng_met = is_eng ? "_e" : "_r";

            for (var i = 0; i < selected_words.Count; i++)
            {
                var gb = new GroupBox();
                gb.Name = $"groupBox{lng_met}_{i + 1}";
                gb.Parent = testForm;
                gb.Text = is_eng ? selected_words[i].Eng : selected_words[i].Rus;
                gb.Dock = DockStyle.Top;
                gb.ForeColor = Color.Magenta;
                gb.AutoSize = true;
                gb.Font = new Font(testForm.Font.FontFamily, 16, FontStyle.Bold);

                var rnd = rand.Next() % 4;
                for (var j = 0; j < 4; j++)
                {
                    try
                    {
                        var rb = new RadioButton();
                        rb.Name = $"radioButton{lng_met}_{i + 1}_{j + 1}";
                        if (rnd == j)
                            rb.Text = is_eng ? selected_words[i].Rus : selected_words[i].Eng;
                        else
                        {
                            var t_words = words.Where(x => 
                            x.eng_lrn_count < Config.count_to_exclude_word && 
                            (   is_eng ? 
                                x.Rus : 
                                x.Eng
                            ) != 
                            (   is_eng ? 
                                selected_words[i].Rus : 
                                selected_words[i].Eng
                            )).ToList();
                            var rnd2 = rand.Next() % t_words.Count;
                            rb.Text = is_eng ? t_words[rnd2].Rus : t_words[rnd2].Eng;
                        }

                        rb.Font = new Font(testForm.Font.FontFamily, 10);
                        rb.AutoSize = true;
                        rb.Parent = gb;
                        rb.Dock = DockStyle.Top;
                        rb.ForeColor = Color.White;
                        rb.Cursor = Cursors.Hand;

                        rb.CheckedChanged += is_eng ?
                            new System.EventHandler(this.radioButton_checkChanged) :
                            new System.EventHandler(this.radioButton_r_checkChanged);

                        rb.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
                        rb.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
                    }
                    catch { }
                }

            }

        }


        void CreateFormForTest(List<Words> selected_eng_words, List<Words> selected_rus_words)
        {
            var testForm = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                BackColor = Color.Black,
                Size = new Size(1000, 600),
                AutoScroll = true
            };

            testForm.VerticalScroll.Visible = true;
            testForm.HorizontalScroll.Visible = true;
            testForm.Show();

            CreateQustuins(testForm, selected_eng_words);
            CreateQustuins(testForm, selected_rus_words, false);
        }
    }
}