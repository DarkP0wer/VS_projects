using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class Form1 : Form
    {
        public List<Words> words = null;

        int flag_IsLeft = -1;
        Random rand;
        //Point cursor_exit = new Point(0, 0);
        Form_Panel_Learn panel_Learn;
        Form_Panel_Edit panel_Edit;


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


        public void TranslateAsync(string text, string sl, string tl, TextBox tb, bool ao = false, CheckBox checkBox_ao = null, TextBox textBox_ao = null)
        {
            Task.Factory.StartNew(() =>
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
                    //Invoke(new Action(() =>
                    //{
                    tb.Text = result;

                    if (!ao && checkBox_ao?.Checked != null && checkBox_ao?.Checked != false)
                    {
                        var q = result;
                        new Thread(() => Translate(q, tl, sl, textBox_ao, true, checkBox_ao, textBox_ao)).Start();
                    }
                    //}));
                }
                catch { }
            });
        }


        private void Repaint_Word(int i)
        {
            try
            {
                var timeLeft = words[i].TimeToRemember - Config.GetUnixTime();
                var row = dataGridView_DB.Rows[i];
                var row_CS = row.DefaultCellStyle;
                var s_eng = row.Cells["ENG"].Value;
                var s_rus = row.Cells["RUS"].Value;

                row_CS.ForeColor = Color.Black;
                row.Cells["T_Left"].Value = Config.GetStringTime(timeLeft);
                row.Cells["ENG"].Value = row.Cells["ENG"].Value+" ";
                row.Cells["RUS"].Value = row.Cells["RUS"].Value+" ";
                row.Cells["ENG"].Value = s_eng;
                row.Cells["RUS"].Value = s_rus;

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
                end_row.Cells["T_Left"].Value = Config.GetStringTime(timeLeft);
                end_row.Cells["Learn"].Value = "Can't";
                end_row.Cells["E_G"].Value = "Link";
                end_row.Cells["Time"].Value = words[i].TimeToRemember;
                end_row.Cells["Step"].Value = words[i].Step;
                Repaint_Word(i);
            }
            catch { }
        }


        public void Reload_Words()
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
            var bt = sender as Button;
            bt.FlatStyle = FlatStyle.Standard;
            bt.BackColor = Color.Black;
        }


        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            var bt = sender as Button;
            bt.FlatStyle = FlatStyle.Flat;
        }


        public void control_chg_MouseEnter(object sender, EventArgs e)
        {
            var control = (Control)sender;

            control.ForeColor = Color.Orange;
        }


        public void control_chg_MouseLeave(object sender, EventArgs e)
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


        public void SelectedRowToEdit()
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
            textBox_eng.Visible = false;
            textBox_rus.Visible = false;

            panel_Edit = new Form_Panel_Edit(this, operation, dataGridView_DB.SelectedCells[0]?.RowIndex);
            

            dataGridView_DB.Visible = false;
        }


        private void ShowLearn()
        {
            panel_word.Visible = false;
            panel_edit_menu.Visible = false;
            panel_Learn = new Form_Panel_Learn(this);
            dataGridView_DB.Visible = false;
        }


        public void CloseLarn()
        {
            panel_edit_menu.Visible = true;
            panel_word.Visible = true;
            panel_Learn.Dispose();
            panel_Learn = null;
            dataGridView_DB.Visible = true;
        }


        public void CloseEdit()
        {
            panel_edit_menu.Visible = true;
            panel_Edit.Dispose();
            panel_Edit = null;
            textBox_eng.Visible = true;
            textBox_rus.Visible = true;
            dataGridView_DB.Visible = true;
        }


        private void button_word_add_Click(object sender, EventArgs e)
        {
            ShowEdit("INSERT");
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


        private void timer_retime_Tick(object sender, EventArgs e)
        {
            var less_count =  Config.countRowsForRetime < dataGridView_DB.Rows.Count ? Config.countRowsForRetime : dataGridView_DB.Rows.Count;

            for (var i = 0; i < dataGridView_DB.Rows.Count; i++)
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
                #region Learn Buttun
                if (senderGrid.Columns[e.ColumnIndex].HeaderText == "Learn")
                {
                    if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "Learn")
                    {
                        MessageBox.Show("You can't learn now!");
                        return;
                    }
                    ShowLearn();
                }
                #endregion
                #region Word Button
                else
                {
                    var text = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    GoogleTranslate.Speak(text, (senderGrid.Columns[e.ColumnIndex].HeaderText == "ENG" ? "en" : "ru"));
                }

                #endregion
                
            }
            #endregion
            #region E. G. link
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                var text = senderGrid.Rows[e.RowIndex].Cells["ENG"].Value.ToString();
                var site = string.Format("http://context.reverso.net/%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4/%D0%B0%D0%BD%D0%B3%D0%BB%D0%B8%D0%B9%D1%81%D0%BA%D0%B8%D0%B9-%D1%80%D1%83%D1%81%D1%81%D0%BA%D0%B8%D0%B9/{0}", Uri.EscapeDataString(text));

                Process.Start(site);
            }
            #endregion
        }


        public void panel_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.User32.ReleaseCapture();
                WinAPI.User32.SendMessage(Handle, WinAPI.User32.WM_NCLBUTTONDOWN, WinAPI.User32.HT_CAPTION, 0);
            }
        }


        private void button_exit_Paint(object sender, PaintEventArgs e)
        {
           /* var bt = (Button)sender;
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
            }*/
        }

        
        private void button_exit_MouseMove(object sender, MouseEventArgs e)
        {
            //cursor_exit = e.Location;
        }


        public void GoToWord(int index, bool accurate = false)
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


        private void button_test_Click(object sender, EventArgs e)
        {
            CreateTest();
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_hide_Click(object sender, EventArgs e)
        {
           this.panel_main.Visible = false;
        }
    }
}