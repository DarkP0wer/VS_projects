using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using WMPLib;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

namespace English
{
    public partial class Form1 : Form
    {
        List<Words> words = null;
        int flag_IsLeft = -1;
        Random rand;
        Point cursor_exit = new Point(0, 0);
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<string> images_base64 = new List<string>();


        public void Translate(string text, string sl, string tl, TextBox tb, bool ao = false, CheckBox checkBox_ao = null, TextBox textBox_ao = null)
        {
            var tk = GoogleTranslate.TL(text);
            var site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(text), sl, tk);
            GoogleTranslate.voice_url[0] = site;
            string result = "";

            try
            {
                var cookies = new CookieContainer();
                ServicePointManager.Expect100Continue = false;
                var request = (HttpWebRequest)WebRequest.Create(string.Format(Config.g_domain + "_a/t?client=mt&sl={0}&tl={1}&hl={1}&v=1.0&source=baf&tk={2}&q={3}", sl, tl, tk, text));

                request.CookieContainer = cookies;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.4) Gecko/20060508 Firefox/1.5.0.4";


                using (var requestStream = request.GetRequestStream())
                using (var responseStream = request.GetResponse().GetResponseStream())
                using (var reader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8")))
                {
                    result = reader.ReadToEnd();
                }

                var startPos = result.IndexOf("\"");
                var endPos = -1;

                if (startPos > -1 && (endPos = result.IndexOf("\"", startPos + 1)) > -1)
                    result = result.Substring(startPos + 1, endPos - startPos - 1);

                tk = GoogleTranslate.TL(result);
            }
            catch { }

            site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(result), tl, tk);
            GoogleTranslate.voice_url[1] = site;

            try
            {
                Invoke(new Action(() =>
                {
                    tb.Text = result;

                    if (ao) return;

                    if (checkBox_ao?.Checked != null && checkBox_ao?.Checked != false)
                    {
                        var q = result;
                        new Thread(() => Translate(q, tl, sl, textBox_ao, true, checkBox_ao, textBox_ao)).Start();
                    }
                }));
            }
            catch { }
        }


        private List<string> GetUrls(string html)
        {
            var urls = new List<string>();

            string search = "eg;base64,(.*?)\"";
            MatchCollection matches = Regex.Matches(html, search);

            foreach (Match match in matches)
            {
                urls.Add(match.Groups[1].Value);
            }

            return urls;
        }


        public Image Base64ToImage(string base64String)
        {
            try
            {
                base64String = base64String.Replace("\\u003d", "=");
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString());  return null; }
        }


        public void GetImage(string text, Control pb)
        {
            var domain = "https://www.google.com.ua";
            var url = $"{domain}/search?q={Uri.EscapeDataString(text)}&tbm=isch";
            string result = "";

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

                var response = (HttpWebResponse)request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(dataStream))
                    {
                        var pos = -1;
                        do
                        {
                            result = sr.ReadLine();
                            pos = result.IndexOf("eg;base64,");
                        }
                        while (pos == -1);
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                        result += sr.ReadLine();
                    }
                }
                var startStr = "eg;base64,";
                var startPos = result.IndexOf(startStr);
                //var endPos = -1;
                images_base64 = GetUrls(result);
                result = images_base64[0];
                /*if (startPos > -1 && (endPos = result.IndexOf("\"", startPos + 1)) > -1)
                    result = result.Substring(startPos + startStr.Length, endPos - startPos - startStr.Length);
                */
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }

            try
            {
                Invoke(new Action(() =>
                {
                    //this.textBox_text.Text = result;
                    pb.BackgroundImage = Base64ToImage(result);
                }));
            }
            catch { }
        }


        private void Repaint_Word(int i)
        {
            try
            {
                var timeLeft = words[i].TimeToRemember - Config.GetUnixTime();
                var row = dataGridView_DB.Rows[i];
                var row_CS = row.DefaultCellStyle;

                row_CS.ForeColor = Color.Black;
                row.Cells["Time_Left"].Value = Config.GetStringTime(timeLeft);

                if (timeLeft <= (int)Config.TimeInSeconds.Now)
                {
                    row_CS.BackColor = Color.Red;
                    row.Cells["Learn"].Value = "Learn";
                }
                else if (timeLeft <= (int)Config.TimeInSeconds.Min_15)
                    row_CS.BackColor = Color.DarkOrange;
                else if (timeLeft <= (int)Config.TimeInSeconds.Hour)
                    row_CS.BackColor = Color.Orange;
                else if (timeLeft <= (int)Config.TimeInSeconds.Hour_3)
                    row_CS.BackColor = Color.Yellow;
                else if (timeLeft <= (int)Config.TimeInSeconds.Day)
                    row_CS.BackColor = Color.DarkGreen;
                else if (timeLeft <= (int)Config.TimeInSeconds.Week)
                    row_CS.BackColor = Color.Green;
                else if (timeLeft <= (int)Config.TimeInSeconds.Month)
                    row_CS.BackColor = Color.FromArgb(0, 255, 254);
                else
                {
                    row_CS.BackColor = Color.Black;
                    row_CS.ForeColor = Color.White;
                }
            }
            catch { }
        }


        private void Reload_Word(int i)
        {
            try
            {
                var timeLeft = words[i].TimeToRemember - Config.GetUnixTime();

                dataGridView_DB.Rows.Add("", "", "", "", "", "", "");

                var end_row = dataGridView_DB.Rows[dataGridView_DB.RowCount - 1];
                
                end_row.Cells["ENG"].Value = words[i].Eng;
                end_row.Cells["RUS"].Value = words[i].Rus;
                end_row.Cells["Time_Left"].Value = Config.GetStringTime(timeLeft);
                end_row.Cells["Learn"].Value = "Can't";
                end_row.Cells["Example"].Value = "Link";
                end_row.Cells["Time"].Value = words[i].TimeToRemember;
                end_row.Cells["Step"].Value = words[i].Step;
                Repaint_Word(i);
            }
            catch { }
        }


        private void Reload_Words()
        {
            try
            {
                dataGridView_DB.Rows.Clear();
                words.Sort((x, y) =>
                        x.TimeToRemember.CompareTo(y.TimeToRemember));

                for (var i = 0; i < words.Count; i++)
                {
                    Reload_Word(i);
                }

                SelectedRowToEdit();
            }
            catch { }
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var index_lng_en = 0;
            var index_lng_ru = 7;

            rand = new Random();
            JSON.LoadFromFile(Config.json_fileName, ref words);
            Reload_Words();
            comboBox_from.SelectedIndex = index_lng_en;
            comboBox_to.SelectedIndex = index_lng_ru;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button_exit.Refresh();
            if (Form.ActiveForm != this && !this.panel_main.Visible)
            {
                var cursor_p = new Point(0, 0);

                this.TopMost = false;
                this.TopMost = true;
                WinAPI.User32.GetCursorPos(ref cursor_p);

                if (cursor_p.Y <= button_show.Height)
                {
                    button_show.Visible = true;

                    if (flag_IsLeft == -1)
                    {
                        flag_IsLeft = DateTime.Now.Second % 2;

                        var dist_min = 60;
                        var dist_max = 100;

                        if (flag_IsLeft == 0)
                        {
                            this.Left = cursor_p.X + (dist_min + rand.Next() % (dist_max - dist_min));

                            if (this.Left + this.Width >= SystemInformation.VirtualScreen.Width)
                                this.Left = this.Left - this.Width - 150;
                        }
                        else
                        {
                            this.Left = cursor_p.X - (dist_min + rand.Next() % (dist_max - dist_min)) - this.Width;

                            if (this.Left < SystemInformation.VirtualScreen.Left)
                                this.Left = 150;
                        }

                        this.Top = 0;
                    }
                }
                else
                {
                    button_show.Visible = false;
                    flag_IsLeft = -1;
                }

                this.ShowInTaskbar = false;
            }
        }


        private void button_show_Click(object sender, EventArgs e)
        {
            this.panel_main.Visible = true;
            this.Left = SystemInformation.VirtualScreen.Width / 2 - this.Width / 2;
            this.ShowInTaskbar = true;
        }


        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            this.button_exit.FlatStyle = FlatStyle.Standard;
            this.button_exit.BackColor = Color.Black;
        }


        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            this.button_exit.FlatStyle = FlatStyle.Flat;
        }


        private void control_chg_MouseEnter(object sender, EventArgs e)
        {
            var control = (Control)sender;

            control.ForeColor = Color.Orange;
        }


        private void control_chg_MouseLeave(object sender, EventArgs e)
        {
            var control = (Control)sender;
            var color = Color.DarkViolet;

            if (control is RadioButton)
                color = Color.White;

            control.ForeColor = color;
        }


        private void textBox_eng_Click(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;

            tb.SelectAll();
        }


        private void SelectedRowToEdit()
        {
            try
            {
                int i = dataGridView_DB.SelectedCells[0].RowIndex;
                var row = dataGridView_DB.Rows[i];

                row.Selected = true;
                textBox_eng.Text = row .Cells["ENG"]
                                        .Value
                                        .ToString();
                textBox_rus.Text = row.Cells["RUS"]
                                        .Value
                                        .ToString();
                textBox_edt_time.Text = row .Cells["Time"]
                                        .Value
                                        .ToString();
                textBox_edt_step.Text = row.Cells["Step"]
                                        .Value
                                        .ToString();

                textBox_edt_eng.Text = textBox_eng.Text;
                textBox_edt_rus.Text = textBox_rus.Text;
            }
            catch { }
        }


        private void dataGridView_DB_Click(object sender, EventArgs e)
        {
            SelectedRowToEdit();
        }


        private void ShowEdit(string operation)
        {
            panel_edit_menu.Visible = false;
            panel_edt.Visible = true;
            textBox_eng.Visible = false;
            textBox_rus.Visible = false;
            label_edt.Text = operation;
            textBox_edt_eng.ReadOnly = false;
            textBox_edt_rus.ReadOnly = false;
            SelectedRowToEdit();

            if(operation == "INSERT")
            {
                textBox_edt_eng.Text = "";
                textBox_edt_rus.Text = "";
                button_ok.Image = imageList_icons16.Images["add.ico"];
            }
            else if(operation == "DELETE")
            {
                textBox_edt_eng.ReadOnly = true;
                textBox_edt_rus.ReadOnly = true;
                button_ok.Image = imageList_icons16.Images["del.ico"];
            }
            else
            {
                button_ok.Image = imageList_icons16.Images["edt.ico"];
            }
        }


        private void ShowLearn()
        {
            panel_word.Visible = false;
            panel_edit_menu.Visible = false;
            panel_learn.Visible = true;

            try
            {
                int i = dataGridView_DB.SelectedCells[0].RowIndex;
                var row = dataGridView_DB.Rows[i];

                button_lrn_eng.Text = row.Cells["ENG"]
                                        .Value
                                        .ToString();

                button_lrn_rus.Text = row.Cells["RUS"]
                                        .Value
                                        .ToString();

                label_lrn_eng.Text = $"Print this: {button_lrn_eng.Text}";


                new Thread(() => GetImage(button_lrn_eng.Text, pictureBox_lrn)).Start();
            }
            catch
            {

            }
            textBox_lrn_eng.Text = "";
            textBox_lrn_eng.Visible = false;
            label_lrn_eng.Visible = false;
            button_lrn_rus.Visible = false;
            button_lrn_ok.Visible = false;

            button_lrn_eng.Image = imageList_icons16.Images["ok_disabled.ico"];
            button_lrn_rus.Image = imageList_icons16.Images["ok_disabled.ico"];
            label_lrn_eng.Image = imageList_icons16.Images["ok_disabled.ico"];
        }


        private void CloseLarn()
        {
            panel_edit_menu.Visible = true;
            panel_learn.Visible = false;
            panel_word.Visible = true;
        }


        private void CloseEdit()
        {
            panel_edit_menu.Visible = true;
            panel_edt.Visible = false;
            textBox_eng.Visible = true;
            textBox_rus.Visible = true;
        }


        private void button_word_add_Click(object sender, EventArgs e)
        {
            ShowEdit("INSERT");
            textBox_edt_eng.Focus();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSON.SaveToFile(Config.json_fileName, ref words);
            Application.ExitThread();

        }


        private void button_word_upd_Click(object sender, EventArgs e)
        {
            ShowEdit("UPDATE");
        }


        private void button_word_del_Click(object sender, EventArgs e)
        {
            ShowEdit("DELETE");
        }


        private void checkBox_word_more_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_word_more.Checked)
            {
                checkBox_word_more.Visible = false;
                panel_edt_step.Visible = true;
                panel_edt_time.Visible = true;
            }
        }


        private void timer_retime_Tick(object sender, EventArgs e)
        {
            var less_count =  Config.countRowsForRetime < dataGridView_DB.Rows.Count ? Config.countRowsForRetime : dataGridView_DB.Rows.Count;

            for (var i = 0; i < less_count; i++)
            {
                Repaint_Word(i);
            }
        }


        private void dataGridView_DB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            #region Buttons
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                #region Word Button
                if (e.ColumnIndex < 2)
                {
                    var text = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var tk = GoogleTranslate.TL(text);
                    var site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(text), (e.ColumnIndex == 0 ? "en" : "ru"), tk);

                    player.URL = site;
                    player.controls.play();
                }

                #endregion
                #region Learn Buttun
                else
                {
                    if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "Learn")
                    {
                        MessageBox.Show("You can't learn now!");
                        return;
                    }
                    ShowLearn();
                }
                #endregion
            }
            #endregion
            #region Example link
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                var text = senderGrid.Rows[e.RowIndex].Cells["ENG"].Value.ToString();
                var site = string.Format("http://context.reverso.net/%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4/%D0%B0%D0%BD%D0%B3%D0%BB%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9-%D1%80%D1%83%D1%81%D1%81%D0%BA%D0%B8%D0%B9/{0}", Uri.EscapeDataString(text));

                Process.Start(site);
            }
            #endregion
        }


        private void comboBox_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_from.SelectedIndex > -1 && comboBox_to.SelectedIndex > -1)
                button_translate.PerformClick();
        }


        private void comboBox_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_from.SelectedIndex > -1 && comboBox_to.SelectedIndex > -1)
                button_translate.PerformClick();
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


        private void button_translate_Click(object sender, EventArgs e)
        {
            var q = textBox_text.Text;
            var sl = comboBox_from.SelectedItem.ToString();
            var tl = comboBox_to.SelectedItem.ToString();

            new Thread(() => Translate(q, sl, tl, textBox_trans, false, this.checkBox_ao, this.textBox_ao)).Start();
        }


        private void textBox_text_TextChanged(object sender, EventArgs e)
        {
            timer_translate_wait.Enabled = false;
            timer_translate_wait.Enabled = true;
        }


        private void timer_translate_wait_Tick(object sender, EventArgs e)
        {
            button_translate.PerformClick();
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


        private void panel_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.User32.ReleaseCapture();
                WinAPI.User32.SendMessage(Handle, WinAPI.User32.WM_NCLBUTTONDOWN, WinAPI.User32.HT_CAPTION, 0);
            }
        }


        private void button_exit_Paint(object sender, PaintEventArgs e)
        {
            var bt = (Button)sender;
            var x_close = 40;
            var gr = e.Graphics;
            if (bt.FlatStyle == FlatStyle.Standard)
            {
                //e.Graphics.DrawRectangle(new Pen(Color.Silver), new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1));
                gr.DrawImage(imageList_mouse.Images[0], new Point(cursor_exit.X - x_close-20, cursor_exit.Y));
                gr.DrawString("HIDE", new Font(bt.Font, FontStyle.Bold), new SolidBrush(Color.Lime), new Point(cursor_exit.X - x_close, cursor_exit.Y));
                gr.DrawString("CLOSE", new Font(bt.Font, FontStyle.Bold), new SolidBrush(Color.Red), new Point(cursor_exit.X + 40, cursor_exit.Y));
                gr.DrawImage(imageList_mouse.Images[0], new Point(cursor_exit.X + 20, cursor_exit.Y));
            }
            else
            {
                gr.DrawImage(imageList_mouse.Images[0], new Point(x_close - 20, bt.Height / 3 - 5));
                gr.DrawString("HIDE", new Font(bt.Font, FontStyle.Bold), new SolidBrush(Color.Lime), new Point(x_close, bt.Height / 3));
                gr.DrawString("CLOSE", new Font(bt.Font, FontStyle.Bold), new SolidBrush(Color.Red), new Point(bt.Width - x_close - 20, bt.Height / 3));
                gr.DrawImage(imageList_mouse.Images[0], new Point(bt.Width - x_close - 40, bt.Height / 3 - 5));   
            }
        }

        
        private void button_exit_MouseMove(object sender, MouseEventArgs e)
        {
            cursor_exit = e.Location;
        }


        private void button_exit_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                this.Close();
            else this.panel_main.Visible = false;
        }


        private void GoToWord(int index, bool accurate = false)
        {
            try
            {
                var nRow = accurate ? index: dataGridView_DB.SelectedCells[0].RowIndex + index;

                if (nRow >= dataGridView_DB.RowCount)
                    nRow = 0;
                if (nRow < 0)
                    nRow = dataGridView_DB.RowCount - 1;

                dataGridView_DB.ClearSelection();
                dataGridView_DB.Rows[nRow].Selected = true;
                SelectedRowToEdit();
            }
            catch {}
        }


        private void button_prev_word_Click(object sender, EventArgs e)
        {
            GoToWord(-1);
        }


        private void button_next_word_Click(object sender, EventArgs e)
        {
            GoToWord(1);
        }


        private void button_cancle_Click(object sender, EventArgs e)
        {
            CloseEdit();
        }


        private void label_edt_time_Click(object sender, EventArgs e)
        {
            textBox_edt_time.Text = Config.GetUnixTime().ToString();
        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            switch (label_edt.Text)
            {
                case "INSERT":
                    {
                        try
                        {
                            var secs = 10;

                            words.Add(new Words(    textBox_edt_eng.Text,
                                                    textBox_edt_rus.Text,
                                                    (checkBox_word_more.Checked ? 
                                                        Convert.ToInt32(textBox_edt_time.Text) - secs : 
                                                        Config.GetUnixTime() + secs
                                                    ),
                                                    (checkBox_word_more.Checked ? 
                                                        Convert.ToInt32(textBox_edt_step.Text) - secs : 
                                                        0
                                                    ),
                                                    0,
                                                    0
                                                ));
                            Reload_Words();
                        }
                        catch { }
                        break;
                    }
                case "UPDATE":
                    {
                        try
                         {
                             int i = dataGridView_DB.SelectedCells[0].RowIndex;
                             words[i].Eng = textBox_edt_eng.Text;
                             words[i].Rus = textBox_edt_rus.Text;
                             words[i].TimeToRemember = Convert.ToInt32(textBox_edt_time.Text);
                             words[i].Step = Convert.ToInt32(textBox_edt_step.Text);
                             Reload_Words();
                         }
                         catch { }
                        break;
                    }
                case "DELETE":
                    {
                        try
                        {
                            int i = dataGridView_DB.SelectedCells[0].RowIndex;
                            words.RemoveAt(i);
                            Reload_Words();
                            GoToWord(i, true);
                        }
                        catch { }
                        break;
                    }
            }

            CloseEdit();
        }


        private void textBox_edt_eng_TextChanged(object sender, EventArgs e)
        {
            timer_edt_translate.Enabled = false;
            timer_edt_translate.Enabled = true;
        }


        private void timer_edt_translate_Tick(object sender, EventArgs e)
        {
            var q = textBox_edt_eng.Text;
            var sl = "en";
            var tl = "ru";

            new Thread(() => Translate(q, sl, tl, textBox_edt_rus, false, this.checkBox_ao, this.textBox_ao)).Start();
            timer_edt_translate.Enabled = false;
        }


        private void button_lrn_cancel_Click(object sender, EventArgs e)
        {
            CloseLarn();
        }


        private void button_lrn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                var i = dataGridView_DB.SelectedCells[0].RowIndex;
                Func<int, int> GetNewTime = (t) => Config.GetUnixTime() + t;

                switch (words[i].Step)
                {
                    case 0:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Min_15);
                        break;
                    case 1:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Hour);
                        break;
                    case 2:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Hour_3);
                        break;
                    case 3:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day);
                        break;
                    case 4:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day_2);
                        break;
                    case 5:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day_4);
                        break;
                    case 6:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Week);
                        break;
                    case 7:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Week_2);
                        break;
                    case 8:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Month);
                        break;
                    case 9:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Month_6);
                        break;
                    default:
                        words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Year);
                        break;
                }
                words[i].Step += 1;
                Reload_Words();
            }
            catch { }
            CloseLarn();
        }


        private void button_lrn_eng_Click(object sender, EventArgs e)
        {
            var text = button_lrn_eng.Text;
            var tk = GoogleTranslate.TL(text);
            var site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(text), "en", tk);

            player.URL = site;
            player.controls.play();

            button_lrn_rus.Visible = true;
            button_lrn_eng.Image = imageList_icons16.Images["ok_enabled.ico"];
        }


        private void button_lrn_rus_Click(object sender, EventArgs e)
        {
            var text = button_lrn_rus.Text;
            var tk = GoogleTranslate.TL(text);
            var site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(text), "ru", tk);

            player.URL = site;
            player.controls.play();

            label_lrn_eng.Visible = true;
            textBox_lrn_eng.Visible = true;
            button_lrn_rus.Image = imageList_icons16.Images["ok_enabled.ico"];
            textBox_lrn_eng.Focus();
        }


        private void textBox_lrn_eng_TextChanged(object sender, EventArgs e)
        {
            if (textBox_lrn_eng.Text.ToLower() == button_lrn_eng.Text.ToLower())
            {
                button_lrn_ok.Visible = true;
                label_lrn_eng.Image = imageList_icons16.Images["ok_enabled.ico"];
            }
        }


        private void textBox_lrn_eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (button_lrn_ok.Visible)
                    button_lrn_ok.PerformClick();
            }
        }


        private void textBox_edt_eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textBox_edt_rus.Focus();
            }
        }
        

        private void textBox_edt_rus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button_ok.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_lrn.BackgroundImage = Base64ToImage(images_base64[DateTime.Now.Second % images_base64.Count]);

            var text = button_lrn_eng.Text;
            var tk = GoogleTranslate.TL(text);
            var site = string.Format(Config.g_domain + "_tts?ie=UTF-8&q={0}&tl={1}&tk={2}&client=webapp", Uri.EscapeDataString(text), "en", tk);

            player.URL = site;
            player.controls.play();
        }


        private void button_test_Click(object sender, EventArgs e)
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

            for (var i = 0; i < selected_eng_words.Count; i++)
            {
                var gb = new GroupBox();
                gb.Name = $"groupBox_{i + 1}";
                gb.Parent = testForm;
                gb.Text = selected_eng_words[i].Eng;
                gb.Dock = DockStyle.Top;
                gb.ForeColor = Color.Magenta;
                gb.Font = new Font(testForm.Font.FontFamily, 16, FontStyle.Bold);

                rnd = rand.Next() % 4;
                for (var j = 0; j < 4; j++)
                {
                    try
                    {
                        var rb = new RadioButton();
                        rb.Name = $"radioButton_{i + 1}_{j + 1}";
                        if (rnd == j)
                            rb.Text = selected_eng_words[i].Rus;
                        else
                        {
                            var eng_words = words.Where(x => x.eng_lrn_count < Config.count_to_exclude_word && x.Rus != selected_eng_words[i].Rus).ToList();
                            var rnd2 = rand.Next() % eng_words.Count;
                            rb.Text = eng_words[rnd2].Rus;
                        }

                        rb.Font = new Font(testForm.Font.FontFamily, 10);
                        rb.AutoSize = true;
                        rb.Parent = gb;
                        rb.Dock = DockStyle.Left;
                        rb.ForeColor = Color.White;
                        rb.Cursor = Cursors.Hand;
                        rb.CheckedChanged += new System.EventHandler(this.radioButton_checkChanged);
                        rb.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
                        rb.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
                    }
                    catch { }
                }
                
            }

            for (var i = 0; i < selected_rus_words.Count; i++)
            {
                var gb = new GroupBox();
                gb.Name = $"groupBox_r_{i + 1}";
                gb.Parent = testForm;
                gb.Text = selected_rus_words[i].Rus;
                gb.Dock = DockStyle.Top;
                gb.ForeColor = Color.Magenta;
                gb.Font = new Font(testForm.Font.FontFamily, 16, FontStyle.Bold);

                rnd = rand.Next() % 4;
                for (var j = 0; j < 4; j++)
                {
                    try
                    {
                        var rb = new RadioButton();
                        rb.Name = $"radioButton_r_{i + 1}_{j + 1}";
                        if (rnd == j)
                            rb.Text = selected_rus_words[i].Eng;
                        else
                        {
                            var rus_words = words.Where(x => x.rus_lrn_count < Config.count_to_exclude_word && x.Eng != selected_rus_words[i].Eng).ToList();
                            var rnd2 = rand.Next() % rus_words.Count;
                            rb.Text = rus_words[rnd2].Eng;
                        }

                        rb.Font = new Font(testForm.Font.FontFamily, 10);
                        rb.AutoSize = true;
                        rb.Parent = gb;
                        rb.Dock = DockStyle.Left;
                        rb.Cursor = Cursors.Hand;
                        rb.ForeColor = Color.White;
                        rb.CheckedChanged += new System.EventHandler(this.radioButton_r_checkChanged);
                        rb.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
                        rb.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
                    }
                    catch { }
                }

            }
        }


        private void radioButton_checkChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var gb = rb.Parent;
            gb.BackColor = Color.Red;
            words.Where(w => w.Eng == gb.Text && w.Rus == rb.Text).ToList().ForEach(f => { f.eng_lrn_count += 1; gb.BackColor = Color.Green; gb.Text += $" ({f.eng_lrn_count})"; });
            gb.Enabled = false;
            new Thread(() => HideGroupBox(gb)).Start();
        }


        private void radioButton_r_checkChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var gb = rb.Parent;
            gb.BackColor = Color.Red;
            words.Where(w => w.Rus == gb.Text && w.Eng == rb.Text).ToList().ForEach(f => { f.rus_lrn_count += 1; gb.BackColor = Color.Green; gb.Text += $" ({f.eng_lrn_count})"; });
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
    }
}