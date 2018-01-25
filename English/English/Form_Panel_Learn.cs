using System;
using System.Windows.Forms;

namespace English
{
    public class Form_Panel_Learn
    {
        private Panel panel_learn;
        private TextBox textBox_lrn_eng;
        private Label label_lrn_eng;
        private Button button_lrn_rus;
        private Form1 form;
        private Panel panel_learn_buttuns;
        private Button button_lrn_ok;
        private Button button_lrn_cancel;
        private Button button_lrn_eng;
        private PictureBox pictureBox_lrn;


        private void Init()
        {
            this.panel_learn = new Panel();
            this.textBox_lrn_eng = new TextBox();
            this.label_lrn_eng = new Label();
            this.button_lrn_rus = new Button();
            this.button_lrn_eng = new Button();
            this.pictureBox_lrn = new PictureBox();
            this.panel_learn_buttuns = new Panel();
            this.button_lrn_ok = new Button();
            this.button_lrn_cancel = new Button();

            this.panel_learn.SuspendLayout();
            form.tabPage_word_book.Controls.Add(this.panel_learn);
            panel_learn.Parent = form.tabPage_word_book;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lrn)).BeginInit();
            this.panel_learn_buttuns.SuspendLayout();// 
            // button_lrn_eng
            // 
            this.button_lrn_eng.Cursor = Cursors.Hand;
            this.button_lrn_eng.Dock = DockStyle.Top;
            this.button_lrn_eng.FlatStyle = FlatStyle.Flat;
            this.button_lrn_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lrn_eng.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_lrn_eng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lrn_eng.Location = new System.Drawing.Point(0, 0);
            this.button_lrn_eng.Name = "button_lrn_eng";
            this.button_lrn_eng.Size = new System.Drawing.Size(486, 50);
            this.button_lrn_eng.TabIndex = 16;
            this.button_lrn_eng.Text = "ENG";
            this.button_lrn_eng.UseVisualStyleBackColor = true;
            this.button_lrn_eng.Click += new System.EventHandler(this.button_lrn_eng_Click);
            this.button_lrn_eng.MouseEnter += new System.EventHandler(form.control_chg_MouseEnter);
            this.button_lrn_eng.MouseLeave += new System.EventHandler(form.control_chg_MouseLeave);
            // 
            // pictureBox_lrn
            // 
            this.pictureBox_lrn.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBox_lrn.Cursor = Cursors.Hand;
            this.pictureBox_lrn.Dock = DockStyle.Right;
            this.pictureBox_lrn.Location = new System.Drawing.Point(486, 0);
            this.pictureBox_lrn.Name = "pictureBox_lrn";
            this.pictureBox_lrn.Size = new System.Drawing.Size(200, 196);
            this.pictureBox_lrn.TabIndex = 20;
            this.pictureBox_lrn.TabStop = false;
            this.pictureBox_lrn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_learn_buttuns
            // 
            this.panel_learn_buttuns.Controls.Add(this.button_lrn_ok);
            this.panel_learn_buttuns.Controls.Add(this.button_lrn_cancel);
            this.panel_learn_buttuns.Dock = DockStyle.Bottom;
            this.panel_learn_buttuns.Location = new System.Drawing.Point(0, 196);
            this.panel_learn_buttuns.Name = "panel_learn_buttuns";
            this.panel_learn_buttuns.Size = new System.Drawing.Size(686, 50);
            this.panel_learn_buttuns.TabIndex = 15;
            // 
            // button_lrn_ok
            // 
            this.button_lrn_ok.Cursor = Cursors.Hand;
            this.button_lrn_ok.Dock = DockStyle.Right;
            this.button_lrn_ok.FlatStyle = FlatStyle.Flat;
            this.button_lrn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lrn_ok.ForeColor = System.Drawing.Color.Lime;
            this.button_lrn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lrn_ok.Location = new System.Drawing.Point(486, 0);
            this.button_lrn_ok.Name = "button_lrn_ok";
            this.button_lrn_ok.Size = new System.Drawing.Size(87, 50);
            this.button_lrn_ok.TabIndex = 13;
            this.button_lrn_ok.Text = "OK";
            this.button_lrn_ok.UseVisualStyleBackColor = true;
            this.button_lrn_ok.Click += new System.EventHandler(this.button_lrn_ok_Click);
            // 
            // button_lrn_cancel
            // 
            this.button_lrn_cancel.Cursor = Cursors.Hand;
            this.button_lrn_cancel.Dock = DockStyle.Right;
            this.button_lrn_cancel.FlatStyle = FlatStyle.Flat;
            this.button_lrn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lrn_cancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_lrn_cancel.Location = new System.Drawing.Point(573, 0);
            this.button_lrn_cancel.Name = "button_lrn_cancel";
            this.button_lrn_cancel.Size = new System.Drawing.Size(113, 50);
            this.button_lrn_cancel.TabIndex = 12;
            this.button_lrn_cancel.Text = "CANCLE";
            this.button_lrn_cancel.UseVisualStyleBackColor = true;
            this.button_lrn_cancel.Click += new System.EventHandler(this.button_lrn_cancel_Click);
            // 
            // button_lrn_rus
            // 
            this.button_lrn_rus.Cursor = Cursors.Hand;
            this.button_lrn_rus.Dock = DockStyle.Top;
            this.button_lrn_rus.FlatStyle = FlatStyle.Flat;
            this.button_lrn_rus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lrn_rus.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_lrn_rus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lrn_rus.Location = new System.Drawing.Point(0, 50);
            this.button_lrn_rus.Name = "button_lrn_rus";
            this.button_lrn_rus.Size = new System.Drawing.Size(486, 50);
            this.button_lrn_rus.TabIndex = 17;
            this.button_lrn_rus.Text = "RUS";
            this.button_lrn_rus.UseVisualStyleBackColor = true;
            this.button_lrn_rus.Click += new System.EventHandler(this.button_lrn_rus_Click);
            this.button_lrn_rus.MouseEnter += new System.EventHandler(form.control_chg_MouseEnter);
            this.button_lrn_rus.MouseLeave += new System.EventHandler(form.control_chg_MouseLeave);
            // 
            // label_lrn_eng
            // 
            this.label_lrn_eng.Dock = DockStyle.Top;
            this.label_lrn_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lrn_eng.ForeColor = System.Drawing.Color.Gold;
            this.label_lrn_eng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_lrn_eng.Location = new System.Drawing.Point(0, 100);
            this.label_lrn_eng.Name = "label_lrn_eng";
            this.label_lrn_eng.Size = new System.Drawing.Size(486, 29);
            this.label_lrn_eng.TabIndex = 19;
            this.label_lrn_eng.Text = "Print: ";
            this.label_lrn_eng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_lrn_eng
            // 
            this.textBox_lrn_eng.BackColor = System.Drawing.Color.Black;
            this.textBox_lrn_eng.BorderStyle = BorderStyle.FixedSingle;
            this.textBox_lrn_eng.Dock = DockStyle.Top;
            this.textBox_lrn_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_lrn_eng.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBox_lrn_eng.Location = new System.Drawing.Point(0, 129);
            this.textBox_lrn_eng.Name = "textBox_lrn_eng";
            this.textBox_lrn_eng.Size = new System.Drawing.Size(486, 44);
            this.textBox_lrn_eng.TabIndex = 18;
            this.textBox_lrn_eng.TextAlign = HorizontalAlignment.Center;
            this.textBox_lrn_eng.TextChanged += new System.EventHandler(this.textBox_lrn_eng_TextChanged);
            this.textBox_lrn_eng.KeyPress += new KeyPressEventHandler(this.textBox_lrn_eng_KeyPress);
            // 
            // panel_learn
            // 
            this.panel_learn.Controls.Add(this.textBox_lrn_eng);
            this.panel_learn.Controls.Add(this.label_lrn_eng);
            this.panel_learn.Controls.Add(this.button_lrn_rus);
            this.panel_learn.Controls.Add(this.button_lrn_eng);
            this.panel_learn.Controls.Add(this.pictureBox_lrn);
            this.panel_learn.Controls.Add(this.panel_learn_buttuns);
            this.panel_learn.Dock = DockStyle.Fill;
            this.panel_learn.Location = new System.Drawing.Point(103, 77);
            this.panel_learn.Name = "panel_learn";
            this.panel_learn.Size = new System.Drawing.Size(686, 246);
            this.panel_learn.TabIndex = 4;


            this.panel_learn.ResumeLayout(false);
            this.panel_learn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lrn)).EndInit();
            this.panel_learn_buttuns.ResumeLayout(false);

        }


        public Form_Panel_Learn(Form1 _form)
        {
            this.form = _form;
            Init();

            try
            {
                int i = form.dataGridView_DB.SelectedCells[0].RowIndex;
                var row = form.dataGridView_DB.Rows[i];

                button_lrn_eng.Text = row.Cells["ENG"]
                                        .Value
                                        .ToString();

                button_lrn_rus.Text = row.Cells["RUS"]
                                        .Value
                                        .ToString();

                label_lrn_eng.Text = $"Print: \"{button_lrn_eng.Text}\"";

                button_lrn_eng.Font = new System.Drawing.Font(button_lrn_eng.Font.FontFamily, (float)(-0.1 * button_lrn_eng.Text.Length + 18));
                button_lrn_rus.Font = new System.Drawing.Font(button_lrn_rus.Font.FontFamily, (float)(-0.1 * button_lrn_rus.Text.Length + 18));
                label_lrn_eng.Font = new System.Drawing.Font(label_lrn_eng.Font.FontFamily, (float)(-0.1 * label_lrn_eng.Text.Length + 17.6));
                new System.Threading.Thread(() => form.GetImage(button_lrn_eng.Text, pictureBox_lrn)).Start();
            }
            catch
            {

            }
            textBox_lrn_eng.Text = "";
            textBox_lrn_eng.Visible = false;
            label_lrn_eng.Visible = false;
            button_lrn_rus.Visible = false;
            button_lrn_ok.Visible = false;

            button_lrn_eng.Image = form.imageList_icons16.Images["ok_disabled.ico"];
            button_lrn_rus.Image = form.imageList_icons16.Images["ok_disabled.ico"];
            label_lrn_eng.Image = form.imageList_icons16.Images["ok_disabled.ico"];
        }


        private void textBox_lrn_eng_TextChanged(object sender, EventArgs e)
        {
            if (textBox_lrn_eng.Text.ToLower() == button_lrn_eng.Text.ToLower())
            {
                button_lrn_ok.Visible = true;
                label_lrn_eng.Image = form.imageList_icons16.Images["ok_enabled.ico"];
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


        private void button_lrn_rus_Click(object sender, EventArgs e)
        {
            GoogleTranslate.Speak(button_lrn_rus.Text, "ru");

            label_lrn_eng.Visible = true;
            textBox_lrn_eng.Visible = true;
            button_lrn_rus.Image = form.imageList_icons16.Images["ok_enabled.ico"];
            textBox_lrn_eng.Focus();
        }


        private void button_lrn_eng_Click(object sender, EventArgs e)
        {
            GoogleTranslate.Speak(button_lrn_eng.Text, "en");

            button_lrn_rus.Visible = true;
            button_lrn_eng.Image = form.imageList_icons16.Images["ok_enabled.ico"];
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_lrn.BackgroundImage = form.Base64ToImage(form.images_base64[DateTime.Now.Second % form.images_base64.Count]);

            GoogleTranslate.Speak(button_lrn_eng.Text, "en");
        }


        private void button_lrn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                var i = form.dataGridView_DB.SelectedCells[0].RowIndex;
                Func<int, int> GetNewTime = (t) => Config.GetUnixTime() + t;

                switch (form.words[i].Step)
                {
                    case 0:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Min_15);
                        break;
                    case 1:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Hour);
                        break;
                    case 2:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Hour_3);
                        break;
                    case 3:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day);
                        break;
                    case 4:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day_2);
                        break;
                    case 5:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Day_4);
                        break;
                    case 6:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Week);
                        break;
                    case 7:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Week_2);
                        break;
                    case 8:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Month);
                        break;
                    case 9:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Month_6);
                        break;
                    default:
                        form.words[i].TimeToRemember = GetNewTime((int)Config.TimeInSeconds.Year);
                        break;
                }
                form.words[i].Step += 1;
                form.Reload_Words();
            }
            catch { }
            form.CloseLarn();
        }


        private void button_lrn_cancel_Click(object sender, EventArgs e)
        {
            form.CloseLarn();
        }


        public void Dispose()
        {
            panel_learn.Dispose();
            textBox_lrn_eng.Dispose();
            label_lrn_eng.Dispose();
            button_lrn_rus.Dispose();
            button_lrn_eng.Dispose();
            pictureBox_lrn.Dispose();
            panel_learn_buttuns.Dispose();
            button_lrn_ok.Dispose();
            button_lrn_cancel.Dispose();

            panel_learn = null;
            textBox_lrn_eng = null;
            label_lrn_eng = null;
            button_lrn_rus = null;
            button_lrn_eng = null;
            pictureBox_lrn = null;
            panel_learn_buttuns = null;
            button_lrn_ok = null;
            button_lrn_cancel = null;
        }
    }
}
