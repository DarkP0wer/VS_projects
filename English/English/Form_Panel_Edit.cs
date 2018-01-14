using System;
using System.Windows.Forms;

namespace English
{
    public class Form_Panel_Edit
    {
        public TextBox textBox_edt_step;
        public TextBox textBox_edt_time;
        public TextBox textBox_edt_eng;
        public TextBox textBox_edt_rus;

        private Panel panel_edt;
        private Panel panel_edt_buttons;
        private Button button_edt_ok;
        private Button button_edt_cancle;
        private Panel panel_edt_rus;
        private Label label_edt_rus;
        private Panel panel_edt_eng;
        private Label label_edt_eng;
        private Panel panel_edt_step;
        private Label label_edt_step;
        private Panel panel_edt_time;
        private Label label_edt_time;
        private Label label_edt;
        private CheckBox checkBox_word_more;
        private Timer timer_edt_translate;
        private Form1 form;


        private void Init()
        {
            this.timer_edt_translate = new Timer(form.components);
            this.panel_edt = new Panel();
            this.panel_edt_rus = new Panel();
            this.textBox_edt_rus = new TextBox();
            this.label_edt_rus = new Label();
            this.panel_edt_eng = new Panel();
            this.textBox_edt_eng = new TextBox();
            this.label_edt_eng = new Label();
            this.checkBox_word_more = new CheckBox();
            this.label_edt = new Label();
            this.panel_edt_time = new Panel();
            this.textBox_edt_time = new TextBox();
            this.label_edt_time = new Label();
            this.panel_edt_step = new Panel();
            this.textBox_edt_step = new TextBox();
            this.label_edt_step = new Label();
            this.panel_edt_buttons = new Panel();
            this.button_edt_ok = new Button();
            this.button_edt_cancle = new Button();


            this.panel_edt.SuspendLayout();
            this.panel_edt_rus.SuspendLayout();
            this.panel_edt_eng.SuspendLayout();
            this.panel_edt_time.SuspendLayout();
            this.panel_edt_step.SuspendLayout();
            this.panel_edt_buttons.SuspendLayout();


            form.tabPage_word_book.Controls.Add(this.panel_edt);
            panel_edt.Parent = form.tabPage_word_book;
            panel_edt.BringToFront();
            // 
            // panel_edt
            // 
            this.panel_edt.Controls.Add(this.panel_edt_rus);
            this.panel_edt.Controls.Add(this.panel_edt_eng);
            this.panel_edt.Controls.Add(this.checkBox_word_more);
            this.panel_edt.Controls.Add(this.label_edt);
            this.panel_edt.Controls.Add(this.panel_edt_time);
            this.panel_edt.Controls.Add(this.panel_edt_step);
            this.panel_edt.Controls.Add(this.panel_edt_buttons);
            this.panel_edt.Cursor = Cursors.SizeAll;
            this.panel_edt.Dock = DockStyle.Fill;
            this.panel_edt.Location = new System.Drawing.Point(103, 77);
            this.panel_edt.Name = "panel_edt";
            this.panel_edt.Size = new System.Drawing.Size(686, 246);
            this.panel_edt.TabIndex = 13;
            this.panel_edt.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // panel_edt_rus
            // 
            this.panel_edt_rus.Controls.Add(this.textBox_edt_rus);
            this.panel_edt_rus.Controls.Add(this.label_edt_rus);
            this.panel_edt_rus.Dock = DockStyle.Top;
            this.panel_edt_rus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_edt_rus.Location = new System.Drawing.Point(0, 66);
            this.panel_edt_rus.Name = "panel_edt_rus";
            this.panel_edt_rus.Size = new System.Drawing.Size(686, 27);
            this.panel_edt_rus.TabIndex = 16;
            // 
            // textBox_edt_rus
            // 
            this.textBox_edt_rus.BackColor = System.Drawing.Color.Black;
            this.textBox_edt_rus.Dock = DockStyle.Fill;
            this.textBox_edt_rus.ForeColor = System.Drawing.Color.Cyan;
            this.textBox_edt_rus.Location = new System.Drawing.Point(137, 0);
            this.textBox_edt_rus.Name = "textBox_edt_rus";
            this.textBox_edt_rus.Size = new System.Drawing.Size(549, 26);
            this.textBox_edt_rus.TabIndex = 1;
            this.textBox_edt_rus.KeyPress += new KeyPressEventHandler(this.textBox_edt_rus_KeyPress);
            // 
            // label_edt_rus
            // 
            this.label_edt_rus.Dock = DockStyle.Left;
            this.label_edt_rus.ForeColor = System.Drawing.Color.Gold;
            this.label_edt_rus.Location = new System.Drawing.Point(0, 0);
            this.label_edt_rus.Name = "label_edt_rus";
            this.label_edt_rus.Size = new System.Drawing.Size(137, 27);
            this.label_edt_rus.TabIndex = 0;
            this.label_edt_rus.Text = "Russian:";
            this.label_edt_rus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edt_rus.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // panel_edt_eng
            // 
            this.panel_edt_eng.Controls.Add(this.textBox_edt_eng);
            this.panel_edt_eng.Controls.Add(this.label_edt_eng);
            this.panel_edt_eng.Dock = DockStyle.Top;
            this.panel_edt_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_edt_eng.Location = new System.Drawing.Point(0, 39);
            this.panel_edt_eng.Name = "panel_edt_eng";
            this.panel_edt_eng.Size = new System.Drawing.Size(686, 27);
            this.panel_edt_eng.TabIndex = 15;
            // 
            // textBox_edt_eng
            // 
            this.textBox_edt_eng.BackColor = System.Drawing.Color.Black;
            this.textBox_edt_eng.Dock = DockStyle.Fill;
            this.textBox_edt_eng.ForeColor = System.Drawing.Color.Cyan;
            this.textBox_edt_eng.Location = new System.Drawing.Point(137, 0);
            this.textBox_edt_eng.Name = "textBox_edt_eng";
            this.textBox_edt_eng.Size = new System.Drawing.Size(549, 26);
            this.textBox_edt_eng.TabIndex = 1;
            this.textBox_edt_eng.TextChanged += new System.EventHandler(this.textBox_edt_eng_TextChanged);
            this.textBox_edt_eng.KeyPress += new KeyPressEventHandler(this.textBox_edt_eng_KeyPress);
            // 
            // label_edt_eng
            // 
            this.label_edt_eng.Dock = DockStyle.Left;
            this.label_edt_eng.ForeColor = System.Drawing.Color.Gold;
            this.label_edt_eng.Location = new System.Drawing.Point(0, 0);
            this.label_edt_eng.Name = "label_edt_eng";
            this.label_edt_eng.Size = new System.Drawing.Size(137, 27);
            this.label_edt_eng.TabIndex = 0;
            this.label_edt_eng.Text = "English:";
            this.label_edt_eng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edt_eng.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // checkBox_word_more
            // 
            this.checkBox_word_more.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_word_more.Cursor = Cursors.Hand;
            this.checkBox_word_more.Dock = DockStyle.Bottom;
            this.checkBox_word_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_word_more.ForeColor = System.Drawing.Color.Magenta;
            this.checkBox_word_more.Location = new System.Drawing.Point(0, 105);
            this.checkBox_word_more.Name = "checkBox_word_more";
            this.checkBox_word_more.Size = new System.Drawing.Size(686, 37);
            this.checkBox_word_more.TabIndex = 11;
            this.checkBox_word_more.TabStop = false;
            this.checkBox_word_more.Text = "More edit";
            this.checkBox_word_more.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_word_more.UseVisualStyleBackColor = true;
            this.checkBox_word_more.CheckedChanged += new System.EventHandler(this.checkBox_word_more_CheckedChanged);
            // 
            // label_edt
            // 
            this.label_edt.Dock = DockStyle.Top;
            this.label_edt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edt.ForeColor = System.Drawing.Color.Red;
            this.label_edt.Location = new System.Drawing.Point(0, 0);
            this.label_edt.Name = "label_edt";
            this.label_edt.Size = new System.Drawing.Size(686, 39);
            this.label_edt.TabIndex = 19;
            this.label_edt.Text = "EDIT:";
            this.label_edt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edt.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // panel_edt_time
            // 
            this.panel_edt_time.Controls.Add(this.textBox_edt_time);
            this.panel_edt_time.Controls.Add(this.label_edt_time);
            this.panel_edt_time.Dock = DockStyle.Bottom;
            this.panel_edt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_edt_time.Location = new System.Drawing.Point(0, 142);
            this.panel_edt_time.Name = "panel_edt_time";
            this.panel_edt_time.Size = new System.Drawing.Size(686, 27);
            this.panel_edt_time.TabIndex = 18;
            this.panel_edt_time.Visible = false;
            // 
            // textBox_edt_time
            // 
            this.textBox_edt_time.BackColor = System.Drawing.Color.Black;
            this.textBox_edt_time.Dock = DockStyle.Fill;
            this.textBox_edt_time.ForeColor = System.Drawing.Color.Cyan;
            this.textBox_edt_time.Location = new System.Drawing.Point(137, 0);
            this.textBox_edt_time.Name = "textBox_edt_time";
            this.textBox_edt_time.Size = new System.Drawing.Size(549, 26);
            this.textBox_edt_time.TabIndex = 1;
            // 
            // label_edt_time
            // 
            this.label_edt_time.Cursor = Cursors.Hand;
            this.label_edt_time.Dock = DockStyle.Left;
            this.label_edt_time.ForeColor = System.Drawing.Color.DarkViolet;
            this.label_edt_time.Location = new System.Drawing.Point(0, 0);
            this.label_edt_time.Name = "label_edt_time";
            this.label_edt_time.Size = new System.Drawing.Size(137, 27);
            this.label_edt_time.TabIndex = 0;
            this.label_edt_time.Text = "Time (UNIX):";
            this.label_edt_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edt_time.Click += new System.EventHandler(this.label_edt_time_Click);
            // 
            // timer_edt_translate
            // 
            this.timer_edt_translate.Interval = 300;
            this.timer_edt_translate.Tick += new System.EventHandler(this.timer_edt_translate_Tick);
            // 
            // panel_edt_step
            // 
            this.panel_edt_step.Controls.Add(this.textBox_edt_step);
            this.panel_edt_step.Controls.Add(this.label_edt_step);
            this.panel_edt_step.Dock = DockStyle.Bottom;
            this.panel_edt_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_edt_step.Location = new System.Drawing.Point(0, 169);
            this.panel_edt_step.Name = "panel_edt_step";
            this.panel_edt_step.Size = new System.Drawing.Size(686, 27);
            this.panel_edt_step.TabIndex = 17;
            this.panel_edt_step.Visible = false;
            // 
            // textBox_edt_step
            // 
            this.textBox_edt_step.BackColor = System.Drawing.Color.Black;
            this.textBox_edt_step.Dock = DockStyle.Fill;
            this.textBox_edt_step.ForeColor = System.Drawing.Color.Cyan;
            this.textBox_edt_step.Location = new System.Drawing.Point(137, 0);
            this.textBox_edt_step.Name = "textBox_edt_step";
            this.textBox_edt_step.Size = new System.Drawing.Size(549, 26);
            this.textBox_edt_step.TabIndex = 1;
            // 
            // label_edt_step
            // 
            this.label_edt_step.Dock = DockStyle.Left;
            this.label_edt_step.ForeColor = System.Drawing.Color.Gold;
            this.label_edt_step.Location = new System.Drawing.Point(0, 0);
            this.label_edt_step.Name = "label_edt_step";
            this.label_edt_step.Size = new System.Drawing.Size(137, 27);
            this.label_edt_step.TabIndex = 0;
            this.label_edt_step.Text = "Step:";
            this.label_edt_step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_edt_step.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // panel_edt_buttons
            // 
            this.panel_edt_buttons.Controls.Add(this.button_edt_ok);
            this.panel_edt_buttons.Controls.Add(this.button_edt_cancle);
            this.panel_edt_buttons.Dock = DockStyle.Bottom;
            this.panel_edt_buttons.Location = new System.Drawing.Point(0, 196);
            this.panel_edt_buttons.Name = "panel_edt_buttons";
            this.panel_edt_buttons.Size = new System.Drawing.Size(686, 50);
            this.panel_edt_buttons.TabIndex = 14;
            this.panel_edt_buttons.MouseDown += new MouseEventHandler(form.panel_main_MouseDown);
            // 
            // button_edt_ok
            // 
            this.button_edt_ok.Cursor = Cursors.Hand;
            this.button_edt_ok.Dock = DockStyle.Right;
            this.button_edt_ok.FlatStyle = FlatStyle.Flat;
            this.button_edt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edt_ok.ForeColor = System.Drawing.Color.Lime;
            this.button_edt_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_edt_ok.Location = new System.Drawing.Point(486, 0);
            this.button_edt_ok.Name = "button_edt_ok";
            this.button_edt_ok.Size = new System.Drawing.Size(87, 50);
            this.button_edt_ok.TabIndex = 13;
            this.button_edt_ok.Text = "OK";
            this.button_edt_ok.UseVisualStyleBackColor = true;
            this.button_edt_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_edt_cancle
            // 
            this.button_edt_cancle.Cursor = Cursors.Hand;
            this.button_edt_cancle.Dock = DockStyle.Right;
            this.button_edt_cancle.FlatStyle = FlatStyle.Flat;
            this.button_edt_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edt_cancle.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_edt_cancle.Location = new System.Drawing.Point(573, 0);
            this.button_edt_cancle.Name = "button_edt_cancle";
            this.button_edt_cancle.Size = new System.Drawing.Size(113, 50);
            this.button_edt_cancle.TabIndex = 12;
            this.button_edt_cancle.Text = "CANCLE";
            this.button_edt_cancle.UseVisualStyleBackColor = true;
            this.button_edt_cancle.Click += new System.EventHandler(this.button_cancle_Click);


            this.panel_edt.ResumeLayout(false);
            this.panel_edt_rus.ResumeLayout(false);
            this.panel_edt_rus.PerformLayout();
            this.panel_edt_eng.ResumeLayout(false);
            this.panel_edt_eng.PerformLayout();
            this.panel_edt_time.ResumeLayout(false);
            this.panel_edt_time.PerformLayout();
            this.panel_edt_step.ResumeLayout(false);
            this.panel_edt_step.PerformLayout();
            this.panel_edt_buttons.ResumeLayout(false);
        }


        public Form_Panel_Edit(Form1 _form, string operation, int? idx)
        {
            this.form = _form;
            Init();

            if (idx != null)
            { 
                var row = form.dataGridView_DB.Rows[(int)idx];
                textBox_edt_time.Text = row.Cells["Time"]
                                            .Value
                                            .ToString();
                textBox_edt_step.Text = row.Cells["Step"]
                                            .Value
                                            .ToString();
                textBox_edt_eng.Text = row.Cells["ENG"]
                                            .Value
                                            .ToString();
                textBox_edt_rus.Text = row.Cells["RUS"]
                                            .Value
                                            .ToString();
            }
            label_edt.Text = operation;

            textBox_edt_eng.ReadOnly = false;
            textBox_edt_rus.ReadOnly = false;
            form.SelectedRowToEdit();

            if (operation == "INSERT")
            {
                textBox_edt_eng.Text = "";
                textBox_edt_rus.Text = "";
                button_edt_ok.Image = form.imageList_icons16.Images["add.ico"];
            }
            else if (operation == "DELETE")
            {
                textBox_edt_eng.ReadOnly = true;
                textBox_edt_rus.ReadOnly = true;
                button_edt_ok.Image = form.imageList_icons16.Images["del.ico"];
            }
            else
            {
                button_edt_ok.Image = form.imageList_icons16.Images["edt.ico"];
            }
            textBox_edt_eng.Focus();
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
                button_edt_ok.PerformClick();
            }
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

            new System.Threading.Thread(() => form.Translate(q, sl, tl, textBox_edt_rus, false, form.checkBox_ao, form.textBox_ao)).Start();
            timer_edt_translate.Enabled = false;
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

                            form.words.Add(new Words(textBox_edt_eng.Text,
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
                            form.Reload_Words();
                        }
                        catch { }
                        break;
                    }
                case "UPDATE":
                    {
                        try
                        {
                            int i = form.dataGridView_DB.SelectedCells[0].RowIndex;
                            form.words[i].Eng = textBox_edt_eng.Text;
                            form.words[i].Rus = textBox_edt_rus.Text;
                            form.words[i].TimeToRemember = Convert.ToInt32(textBox_edt_time.Text);
                            form.words[i].Step = Convert.ToInt32(textBox_edt_step.Text);
                            form.Reload_Words();
                        }
                        catch { }
                        break;
                    }
                case "DELETE":
                    {
                        try
                        {
                            int i = form.dataGridView_DB.SelectedCells[0].RowIndex;
                            form.words.RemoveAt(i);
                            form.Reload_Words();
                            form.GoToWord(i, true);
                        }
                        catch { }
                        break;
                    }
            }

            form.CloseEdit();
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


        private void button_cancle_Click(object sender, EventArgs e)
        {
            form.CloseEdit();
        }


        public void Dispose()
        {
            panel_edt.Dispose();
            panel_edt_buttons.Dispose();
            button_edt_ok.Dispose();
            button_edt_cancle.Dispose();
            panel_edt_rus.Dispose();
            textBox_edt_rus.Dispose();
            label_edt_rus.Dispose();
            panel_edt_eng.Dispose();
            textBox_edt_eng.Dispose();
            label_edt_eng.Dispose();
            panel_edt_step.Dispose();
            textBox_edt_step.Dispose();
            label_edt_step.Dispose();
            panel_edt_time.Dispose();
            textBox_edt_time.Dispose();
            label_edt_time.Dispose();
            label_edt.Dispose();
            checkBox_word_more.Dispose();
            timer_edt_translate.Dispose();

            panel_edt = null;
            panel_edt_buttons = null;
            button_edt_ok = null;
            button_edt_cancle = null;
            panel_edt_rus = null;
            textBox_edt_rus = null;
            label_edt_rus = null;
            panel_edt_eng = null;
            textBox_edt_eng = null;
            label_edt_eng = null;
            panel_edt_step = null;
            textBox_edt_step = null;
            label_edt_step = null;
            panel_edt_time = null;
            textBox_edt_time = null;
            label_edt_time = null;
            label_edt = null;
            checkBox_word_more = null;
            timer_edt_translate = null;
        }
    }
}
