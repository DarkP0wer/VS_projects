namespace BrightnessTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label_info = new System.Windows.Forms.Label();
            this.timer_clear_text = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.BackColor = System.Drawing.Color.Black;
            this.label_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.ForeColor = System.Drawing.Color.Gold;
            this.label_info.Location = new System.Drawing.Point(0, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(1386, 788);
            this.label_info.TabIndex = 0;
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_clear_text
            // 
            this.timer_clear_text.Interval = 5000;
            this.timer_clear_text.Tick += new System.EventHandler(this.timer_clear_text_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Timer timer_clear_text;
    }
}

