namespace English
{
    partial class Form1
    {

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_repaint = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_word_book = new System.Windows.Forms.TabPage();
            this.dataGridView_DB = new System.Windows.Forms.DataGridView();
            this.Learn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.T_Left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENG = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RUS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.E_G = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_edit_menu = new System.Windows.Forms.Panel();
            this.button_test = new System.Windows.Forms.Button();
            this.button_word_add = new System.Windows.Forms.Button();
            this.button_word_upd = new System.Windows.Forms.Button();
            this.button_word_del = new System.Windows.Forms.Button();
            this.panel_word = new System.Windows.Forms.Panel();
            this.textBox_rus = new System.Windows.Forms.TextBox();
            this.textBox_eng = new System.Windows.Forms.TextBox();
            this.button_prev_word = new System.Windows.Forms.Button();
            this.button_next_word = new System.Windows.Forms.Button();
            this.tabPage_google_translate = new System.Windows.Forms.TabPage();
            this.panel_trans_text = new System.Windows.Forms.Panel();
            this.textBox_trans = new System.Windows.Forms.TextBox();
            this.textBox_ao = new System.Windows.Forms.TextBox();
            this.panel_translate = new System.Windows.Forms.Panel();
            this.button_translate = new System.Windows.Forms.Button();
            this.button_speak_to = new System.Windows.Forms.Button();
            this.button_speak_from = new System.Windows.Forms.Button();
            this.checkBox_ao = new System.Windows.Forms.CheckBox();
            this.comboBox_to = new System.Windows.Forms.ComboBox();
            this.label_to = new System.Windows.Forms.Label();
            this.button_r = new System.Windows.Forms.Button();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.label_from = new System.Windows.Forms.Label();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.panel_system = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.timer_retime = new System.Windows.Forms.Timer(this.components);
            this.timer_translate_wait = new System.Windows.Forms.Timer(this.components);
            this.imageList_mouse = new System.Windows.Forms.ImageList(this.components);
            this.imageList_icons16 = new System.Windows.Forms.ImageList(this.components);
            this.panel_main.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_word_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).BeginInit();
            this.panel_edit_menu.SuspendLayout();
            this.panel_word.SuspendLayout();
            this.tabPage_google_translate.SuspendLayout();
            this.panel_trans_text.SuspendLayout();
            this.panel_translate.SuspendLayout();
            this.panel_system.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_repaint
            // 
            this.timer_repaint.Enabled = true;
            this.timer_repaint.Interval = 20;
            this.timer_repaint.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.tabControl1);
            this.panel_main.Controls.Add(this.panel_system);
            this.panel_main.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 385);
            this.panel_main.TabIndex = 2;
            this.panel_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_word_book);
            this.tabControl1.Controls.Add(this.tabPage_google_translate);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 355);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage_word_book
            // 
            this.tabPage_word_book.BackColor = System.Drawing.Color.Black;
            this.tabPage_word_book.Controls.Add(this.dataGridView_DB);
            this.tabPage_word_book.Controls.Add(this.panel_edit_menu);
            this.tabPage_word_book.Controls.Add(this.panel_word);
            this.tabPage_word_book.ForeColor = System.Drawing.Color.Black;
            this.tabPage_word_book.Location = new System.Drawing.Point(4, 25);
            this.tabPage_word_book.Name = "tabPage_word_book";
            this.tabPage_word_book.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_word_book.Size = new System.Drawing.Size(792, 326);
            this.tabPage_word_book.TabIndex = 0;
            this.tabPage_word_book.Text = "WordBook";
            // 
            // dataGridView_DB
            // 
            this.dataGridView_DB.AllowUserToAddRows = false;
            this.dataGridView_DB.AllowUserToDeleteRows = false;
            this.dataGridView_DB.AllowUserToResizeRows = false;
            this.dataGridView_DB.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_DB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Learn,
            this.T_Left,
            this.ENG,
            this.RUS,
            this.E_G,
            this.Time,
            this.Step});
            this.dataGridView_DB.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DB.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_DB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DB.EnableHeadersVisualStyles = false;
            this.dataGridView_DB.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_DB.Location = new System.Drawing.Point(103, 77);
            this.dataGridView_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_DB.MultiSelect = false;
            this.dataGridView_DB.Name = "dataGridView_DB";
            this.dataGridView_DB.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DB.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_DB.RowHeadersVisible = false;
            this.dataGridView_DB.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView_DB.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_DB.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_DB.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_DB.Size = new System.Drawing.Size(686, 246);
            this.dataGridView_DB.TabIndex = 2;
            this.dataGridView_DB.TabStop = false;
            this.dataGridView_DB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DB_CellContentClick);
            this.dataGridView_DB.Click += new System.EventHandler(this.dataGridView_DB_Click);
            // 
            // Learn
            // 
            this.Learn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Learn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Learn.HeaderText = "Learn";
            this.Learn.Name = "Learn";
            this.Learn.ReadOnly = true;
            this.Learn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Learn.Width = 48;
            // 
            // T_Left
            // 
            this.T_Left.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.T_Left.HeaderText = "T_Left";
            this.T_Left.Name = "T_Left";
            this.T_Left.ReadOnly = true;
            this.T_Left.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.T_Left.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.T_Left.Width = 51;
            // 
            // ENG
            // 
            this.ENG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet;
            this.ENG.DefaultCellStyle = dataGridViewCellStyle2;
            this.ENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENG.HeaderText = "ENG";
            this.ENG.Name = "ENG";
            this.ENG.ReadOnly = true;
            this.ENG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ENG.ToolTipText = "♫";
            this.ENG.Width = 43;
            // 
            // RUS
            // 
            this.RUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Aqua;
            this.RUS.DefaultCellStyle = dataGridViewCellStyle3;
            this.RUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RUS.HeaderText = "RUS";
            this.RUS.Name = "RUS";
            this.RUS.ReadOnly = true;
            this.RUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RUS.ToolTipText = "♫";
            this.RUS.Width = 43;
            // 
            // E_G
            // 
            this.E_G.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.E_G.HeaderText = "E_G";
            this.E_G.Name = "E_G";
            this.E_G.ReadOnly = true;
            this.E_G.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.E_G.Width = 40;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 45;
            // 
            // Step
            // 
            this.Step.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Step.DefaultCellStyle = dataGridViewCellStyle4;
            this.Step.HeaderText = "Step";
            this.Step.Name = "Step";
            this.Step.ReadOnly = true;
            this.Step.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Step.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Step.Width = 42;
            // 
            // panel_edit_menu
            // 
            this.panel_edit_menu.Controls.Add(this.button_test);
            this.panel_edit_menu.Controls.Add(this.button_word_add);
            this.panel_edit_menu.Controls.Add(this.button_word_upd);
            this.panel_edit_menu.Controls.Add(this.button_word_del);
            this.panel_edit_menu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_edit_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_edit_menu.ForeColor = System.Drawing.Color.White;
            this.panel_edit_menu.Location = new System.Drawing.Point(3, 77);
            this.panel_edit_menu.Name = "panel_edit_menu";
            this.panel_edit_menu.Size = new System.Drawing.Size(100, 246);
            this.panel_edit_menu.TabIndex = 5;
            this.panel_edit_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            // 
            // button_test
            // 
            this.button_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_test.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_test.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_test.Location = new System.Drawing.Point(0, 46);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(100, 50);
            this.button_test.TabIndex = 12;
            this.button_test.Text = "TEST";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            this.button_test.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_test.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // button_word_add
            // 
            this.button_word_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_word_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_word_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_word_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_word_add.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_word_add.Location = new System.Drawing.Point(0, 96);
            this.button_word_add.Name = "button_word_add";
            this.button_word_add.Size = new System.Drawing.Size(100, 50);
            this.button_word_add.TabIndex = 5;
            this.button_word_add.Text = "ADD";
            this.button_word_add.UseVisualStyleBackColor = true;
            this.button_word_add.Click += new System.EventHandler(this.button_word_add_Click);
            this.button_word_add.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_word_add.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // button_word_upd
            // 
            this.button_word_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_word_upd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_word_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_word_upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_word_upd.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_word_upd.Location = new System.Drawing.Point(0, 146);
            this.button_word_upd.Name = "button_word_upd";
            this.button_word_upd.Size = new System.Drawing.Size(100, 50);
            this.button_word_upd.TabIndex = 6;
            this.button_word_upd.Text = "UPD";
            this.button_word_upd.UseVisualStyleBackColor = true;
            this.button_word_upd.Click += new System.EventHandler(this.button_word_upd_Click);
            this.button_word_upd.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_word_upd.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // button_word_del
            // 
            this.button_word_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_word_del.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_word_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_word_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_word_del.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_word_del.Location = new System.Drawing.Point(0, 196);
            this.button_word_del.Name = "button_word_del";
            this.button_word_del.Size = new System.Drawing.Size(100, 50);
            this.button_word_del.TabIndex = 11;
            this.button_word_del.Text = "DEL";
            this.button_word_del.UseVisualStyleBackColor = true;
            this.button_word_del.Click += new System.EventHandler(this.button_word_del_Click);
            this.button_word_del.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_word_del.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // panel_word
            // 
            this.panel_word.Controls.Add(this.textBox_rus);
            this.panel_word.Controls.Add(this.textBox_eng);
            this.panel_word.Controls.Add(this.button_prev_word);
            this.panel_word.Controls.Add(this.button_next_word);
            this.panel_word.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_word.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_word.Location = new System.Drawing.Point(3, 3);
            this.panel_word.Name = "panel_word";
            this.panel_word.Size = new System.Drawing.Size(786, 74);
            this.panel_word.TabIndex = 12;
            this.panel_word.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            // 
            // textBox_rus
            // 
            this.textBox_rus.BackColor = System.Drawing.Color.Black;
            this.textBox_rus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_rus.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_rus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_rus.ForeColor = System.Drawing.Color.Gold;
            this.textBox_rus.Location = new System.Drawing.Point(64, 37);
            this.textBox_rus.Name = "textBox_rus";
            this.textBox_rus.ReadOnly = true;
            this.textBox_rus.Size = new System.Drawing.Size(658, 37);
            this.textBox_rus.TabIndex = 1;
            this.textBox_rus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_rus.Click += new System.EventHandler(this.textBox_eng_Click);
            // 
            // textBox_eng
            // 
            this.textBox_eng.BackColor = System.Drawing.Color.Black;
            this.textBox_eng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_eng.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_eng.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBox_eng.Location = new System.Drawing.Point(64, 0);
            this.textBox_eng.Name = "textBox_eng";
            this.textBox_eng.ReadOnly = true;
            this.textBox_eng.Size = new System.Drawing.Size(658, 37);
            this.textBox_eng.TabIndex = 0;
            this.textBox_eng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_eng.Click += new System.EventHandler(this.textBox_eng_Click);
            // 
            // button_prev_word
            // 
            this.button_prev_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev_word.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_prev_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev_word.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_prev_word.Location = new System.Drawing.Point(0, 0);
            this.button_prev_word.Name = "button_prev_word";
            this.button_prev_word.Size = new System.Drawing.Size(64, 74);
            this.button_prev_word.TabIndex = 3;
            this.button_prev_word.Text = "←";
            this.button_prev_word.UseVisualStyleBackColor = true;
            this.button_prev_word.Click += new System.EventHandler(this.button_prev_word_Click);
            this.button_prev_word.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_prev_word.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // button_next_word
            // 
            this.button_next_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next_word.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_next_word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next_word.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_next_word.Location = new System.Drawing.Point(722, 0);
            this.button_next_word.Name = "button_next_word";
            this.button_next_word.Size = new System.Drawing.Size(64, 74);
            this.button_next_word.TabIndex = 2;
            this.button_next_word.Text = "→";
            this.button_next_word.UseVisualStyleBackColor = true;
            this.button_next_word.Click += new System.EventHandler(this.button_next_word_Click);
            this.button_next_word.MouseEnter += new System.EventHandler(this.control_chg_MouseEnter);
            this.button_next_word.MouseLeave += new System.EventHandler(this.control_chg_MouseLeave);
            // 
            // tabPage_google_translate
            // 
            this.tabPage_google_translate.BackColor = System.Drawing.Color.Black;
            this.tabPage_google_translate.Controls.Add(this.panel_trans_text);
            this.tabPage_google_translate.Controls.Add(this.panel_translate);
            this.tabPage_google_translate.Controls.Add(this.textBox_text);
            this.tabPage_google_translate.Location = new System.Drawing.Point(4, 25);
            this.tabPage_google_translate.Name = "tabPage_google_translate";
            this.tabPage_google_translate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_google_translate.Size = new System.Drawing.Size(792, 326);
            this.tabPage_google_translate.TabIndex = 1;
            this.tabPage_google_translate.Text = "GTranslate";
            // 
            // panel_trans_text
            // 
            this.panel_trans_text.Controls.Add(this.textBox_trans);
            this.panel_trans_text.Controls.Add(this.textBox_ao);
            this.panel_trans_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_trans_text.Location = new System.Drawing.Point(567, 3);
            this.panel_trans_text.Name = "panel_trans_text";
            this.panel_trans_text.Size = new System.Drawing.Size(222, 320);
            this.panel_trans_text.TabIndex = 2;
            // 
            // textBox_trans
            // 
            this.textBox_trans.BackColor = System.Drawing.Color.Black;
            this.textBox_trans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_trans.ForeColor = System.Drawing.Color.Orange;
            this.textBox_trans.Location = new System.Drawing.Point(0, 0);
            this.textBox_trans.Multiline = true;
            this.textBox_trans.Name = "textBox_trans";
            this.textBox_trans.Size = new System.Drawing.Size(222, 155);
            this.textBox_trans.TabIndex = 3;
            // 
            // textBox_ao
            // 
            this.textBox_ao.BackColor = System.Drawing.Color.Black;
            this.textBox_ao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_ao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ao.ForeColor = System.Drawing.Color.Orange;
            this.textBox_ao.Location = new System.Drawing.Point(0, 155);
            this.textBox_ao.Multiline = true;
            this.textBox_ao.Name = "textBox_ao";
            this.textBox_ao.Size = new System.Drawing.Size(222, 165);
            this.textBox_ao.TabIndex = 4;
            this.textBox_ao.Visible = false;
            // 
            // panel_translate
            // 
            this.panel_translate.Controls.Add(this.button_translate);
            this.panel_translate.Controls.Add(this.button_speak_to);
            this.panel_translate.Controls.Add(this.button_speak_from);
            this.panel_translate.Controls.Add(this.checkBox_ao);
            this.panel_translate.Controls.Add(this.comboBox_to);
            this.panel_translate.Controls.Add(this.label_to);
            this.panel_translate.Controls.Add(this.button_r);
            this.panel_translate.Controls.Add(this.comboBox_from);
            this.panel_translate.Controls.Add(this.label_from);
            this.panel_translate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_translate.Location = new System.Drawing.Point(358, 3);
            this.panel_translate.Name = "panel_translate";
            this.panel_translate.Padding = new System.Windows.Forms.Padding(3);
            this.panel_translate.Size = new System.Drawing.Size(209, 320);
            this.panel_translate.TabIndex = 1;
            // 
            // button_translate
            // 
            this.button_translate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_translate.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_translate.ForeColor = System.Drawing.Color.Turquoise;
            this.button_translate.Location = new System.Drawing.Point(3, 239);
            this.button_translate.Margin = new System.Windows.Forms.Padding(5);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(203, 40);
            this.button_translate.TabIndex = 9;
            this.button_translate.Text = "☻ Translate ☻";
            this.button_translate.UseVisualStyleBackColor = true;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // button_speak_to
            // 
            this.button_speak_to.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_speak_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_speak_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_speak_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_speak_to.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_speak_to.Location = new System.Drawing.Point(3, 199);
            this.button_speak_to.Margin = new System.Windows.Forms.Padding(5);
            this.button_speak_to.Name = "button_speak_to";
            this.button_speak_to.Size = new System.Drawing.Size(203, 40);
            this.button_speak_to.TabIndex = 11;
            this.button_speak_to.Text = "Speak ♫ ►";
            this.button_speak_to.UseVisualStyleBackColor = true;
            this.button_speak_to.Click += new System.EventHandler(this.button_speak_to_Click);
            // 
            // button_speak_from
            // 
            this.button_speak_from.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_speak_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_speak_from.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_speak_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_speak_from.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_speak_from.Location = new System.Drawing.Point(3, 159);
            this.button_speak_from.Margin = new System.Windows.Forms.Padding(5);
            this.button_speak_from.Name = "button_speak_from";
            this.button_speak_from.Size = new System.Drawing.Size(203, 40);
            this.button_speak_from.TabIndex = 10;
            this.button_speak_from.Text = "◄ ♫ Speak";
            this.button_speak_from.UseVisualStyleBackColor = true;
            this.button_speak_from.Click += new System.EventHandler(this.button_speak_from_Click);
            // 
            // checkBox_ao
            // 
            this.checkBox_ao.AutoSize = true;
            this.checkBox_ao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_ao.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ao.ForeColor = System.Drawing.Color.DarkViolet;
            this.checkBox_ao.Location = new System.Drawing.Point(3, 131);
            this.checkBox_ao.Name = "checkBox_ao";
            this.checkBox_ao.Size = new System.Drawing.Size(203, 28);
            this.checkBox_ao.TabIndex = 8;
            this.checkBox_ao.Text = "Another one";
            this.checkBox_ao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_ao.UseVisualStyleBackColor = true;
            this.checkBox_ao.CheckedChanged += new System.EventHandler(this.checkBox_ao_CheckedChanged);
            // 
            // comboBox_to
            // 
            this.comboBox_to.AutoCompleteCustomSource.AddRange(new string[] {
            "en",
            "ar",
            "be",
            "es",
            "it",
            "zh-CN",
            "de",
            "ru",
            "uk",
            "fr",
            "ja",
            "tr"});
            this.comboBox_to.BackColor = System.Drawing.Color.Black;
            this.comboBox_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_to.ForeColor = System.Drawing.Color.Orange;
            this.comboBox_to.FormattingEnabled = true;
            this.comboBox_to.Items.AddRange(new object[] {
            "en",
            "ar",
            "be",
            "es",
            "it",
            "zh-CN",
            "de",
            "ru",
            "uk",
            "fr",
            "ja",
            "tr"});
            this.comboBox_to.Location = new System.Drawing.Point(3, 107);
            this.comboBox_to.Name = "comboBox_to";
            this.comboBox_to.Size = new System.Drawing.Size(203, 24);
            this.comboBox_to.TabIndex = 5;
            this.comboBox_to.SelectedIndexChanged += new System.EventHandler(this.comboBox_to_SelectedIndexChanged);
            // 
            // label_to
            // 
            this.label_to.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_to.Location = new System.Drawing.Point(3, 88);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(203, 19);
            this.label_to.TabIndex = 1;
            this.label_to.Text = "To:";
            this.label_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_r
            // 
            this.button_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_r.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_r.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_r.Location = new System.Drawing.Point(3, 48);
            this.button_r.Margin = new System.Windows.Forms.Padding(5);
            this.button_r.Name = "button_r";
            this.button_r.Size = new System.Drawing.Size(203, 40);
            this.button_r.TabIndex = 7;
            this.button_r.Text = "↕ Replace ↕";
            this.button_r.UseVisualStyleBackColor = true;
            this.button_r.Click += new System.EventHandler(this.button_r_Click);
            // 
            // comboBox_from
            // 
            this.comboBox_from.AutoCompleteCustomSource.AddRange(new string[] {
            "en",
            "ar",
            "be",
            "es",
            "it",
            "zh-CN",
            "de",
            "ru",
            "uk",
            "fr",
            "ja",
            "tr"});
            this.comboBox_from.BackColor = System.Drawing.Color.Black;
            this.comboBox_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_from.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_from.ForeColor = System.Drawing.Color.Orange;
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Items.AddRange(new object[] {
            "en",
            "ar",
            "be",
            "es",
            "it",
            "zh-CN",
            "de",
            "ru",
            "uk",
            "fr",
            "ja",
            "tr"});
            this.comboBox_from.Location = new System.Drawing.Point(3, 24);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(203, 24);
            this.comboBox_from.TabIndex = 6;
            this.comboBox_from.SelectedIndexChanged += new System.EventHandler(this.comboBox_from_SelectedIndexChanged);
            // 
            // label_from
            // 
            this.label_from.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_from.Location = new System.Drawing.Point(3, 3);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(203, 21);
            this.label_from.TabIndex = 0;
            this.label_from.Text = "From:";
            this.label_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_text
            // 
            this.textBox_text.BackColor = System.Drawing.Color.Black;
            this.textBox_text.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_text.ForeColor = System.Drawing.Color.Orange;
            this.textBox_text.Location = new System.Drawing.Point(3, 3);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(355, 320);
            this.textBox_text.TabIndex = 0;
            this.textBox_text.TextChanged += new System.EventHandler(this.textBox_text_TextChanged);
            // 
            // panel_system
            // 
            this.panel_system.BackColor = System.Drawing.Color.Black;
            this.panel_system.Controls.Add(this.button_hide);
            this.panel_system.Controls.Add(this.button_exit);
            this.panel_system.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_system.Location = new System.Drawing.Point(0, 0);
            this.panel_system.Name = "panel_system";
            this.panel_system.Size = new System.Drawing.Size(800, 30);
            this.panel_system.TabIndex = 7;
            this.panel_system.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            // 
            // button_hide
            // 
            this.button_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hide.ForeColor = System.Drawing.Color.Gray;
            this.button_hide.Location = new System.Drawing.Point(658, 0);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(71, 30);
            this.button_hide.TabIndex = 7;
            this.button_hide.TabStop = false;
            this.button_hide.Text = "--";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            this.button_hide.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_hide.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(729, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(71, 30);
            this.button_exit.TabIndex = 6;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.Paint += new System.Windows.Forms.PaintEventHandler(this.button_exit_Paint);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            this.button_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_exit_MouseMove);
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.Transparent;
            this.button_show.BackgroundImage = global::English.Properties.Resources.down;
            this.button_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Location = new System.Drawing.Point(0, 0);
            this.button_show.Margin = new System.Windows.Forms.Padding(0);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(100, 30);
            this.button_show.TabIndex = 1;
            this.button_show.TabStop = false;
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Visible = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // timer_retime
            // 
            this.timer_retime.Enabled = true;
            this.timer_retime.Interval = 1000;
            this.timer_retime.Tick += new System.EventHandler(this.timer_retime_Tick);
            // 
            // timer_translate_wait
            // 
            this.timer_translate_wait.Interval = 500;
            this.timer_translate_wait.Tick += new System.EventHandler(this.timer_translate_wait_Tick);
            // 
            // imageList_mouse
            // 
            this.imageList_mouse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_mouse.ImageStream")));
            this.imageList_mouse.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_mouse.Images.SetKeyName(0, "mouse(2).png");
            this.imageList_mouse.Images.SetKeyName(1, "add.ico");
            this.imageList_mouse.Images.SetKeyName(2, "edit.ico");
            this.imageList_mouse.Images.SetKeyName(3, "delete.ico");
            // 
            // imageList_icons16
            // 
            this.imageList_icons16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icons16.ImageStream")));
            this.imageList_icons16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icons16.Images.SetKeyName(0, "add.ico");
            this.imageList_icons16.Images.SetKeyName(1, "edt.ico");
            this.imageList_icons16.Images.SetKeyName(2, "del.ico");
            this.imageList_icons16.Images.SetKeyName(3, "ok_enabled.ico");
            this.imageList_icons16.Images.SetKeyName(4, "ok_disabled.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1051, 449);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_show);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, -1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "English";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_main.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_word_book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).EndInit();
            this.panel_edit_menu.ResumeLayout(false);
            this.panel_word.ResumeLayout(false);
            this.panel_word.PerformLayout();
            this.tabPage_google_translate.ResumeLayout(false);
            this.tabPage_google_translate.PerformLayout();
            this.panel_trans_text.ResumeLayout(false);
            this.panel_trans_text.PerformLayout();
            this.panel_translate.ResumeLayout(false);
            this.panel_translate.PerformLayout();
            this.panel_system.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_repaint;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage_word_book;
        private System.Windows.Forms.Panel panel_edit_menu;
        public System.Windows.Forms.DataGridView dataGridView_DB;
        private System.Windows.Forms.TabPage tabPage_google_translate;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_word_del;
        private System.Windows.Forms.Button button_word_upd;
        private System.Windows.Forms.Button button_word_add;
        private System.Windows.Forms.TextBox textBox_rus;
        private System.Windows.Forms.TextBox textBox_eng;
        private System.Windows.Forms.Timer timer_retime;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Panel panel_translate;
        public System.Windows.Forms.CheckBox checkBox_ao;
        private System.Windows.Forms.ComboBox comboBox_to;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Button button_r;
        private System.Windows.Forms.ComboBox comboBox_from;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Panel panel_trans_text;
        private System.Windows.Forms.TextBox textBox_trans;
        public System.Windows.Forms.TextBox textBox_ao;
        private System.Windows.Forms.Button button_translate;
        private System.Windows.Forms.Timer timer_translate_wait;
        private System.Windows.Forms.Button button_speak_to;
        private System.Windows.Forms.Button button_speak_from;
        private System.Windows.Forms.ImageList imageList_mouse;
        private System.Windows.Forms.Panel panel_word;
        private System.Windows.Forms.Button button_prev_word;
        private System.Windows.Forms.Button button_next_word;
        public System.Windows.Forms.ImageList imageList_icons16;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.DataGridViewButtonColumn Learn;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Left;
        private System.Windows.Forms.DataGridViewButtonColumn ENG;
        private System.Windows.Forms.DataGridViewButtonColumn RUS;
        private System.Windows.Forms.DataGridViewLinkColumn E_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.Panel panel_system;
        private System.Windows.Forms.Button button_hide;
        private System.ComponentModel.IContainer components;
    }
}

