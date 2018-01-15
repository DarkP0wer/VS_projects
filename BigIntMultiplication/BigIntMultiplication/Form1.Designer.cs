namespace BigIntMultiplication
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
            this.textBox_ab = new System.Windows.Forms.TextBox();
            this.textBox_dc = new System.Windows.Forms.TextBox();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_ab
            // 
            this.textBox_ab.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_ab.Location = new System.Drawing.Point(0, 0);
            this.textBox_ab.Multiline = true;
            this.textBox_ab.Name = "textBox_ab";
            this.textBox_ab.Size = new System.Drawing.Size(284, 54);
            this.textBox_ab.TabIndex = 0;
            // 
            // textBox_dc
            // 
            this.textBox_dc.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_dc.Location = new System.Drawing.Point(0, 54);
            this.textBox_dc.Multiline = true;
            this.textBox_dc.Name = "textBox_dc";
            this.textBox_dc.Size = new System.Drawing.Size(284, 54);
            this.textBox_dc.TabIndex = 1;
            // 
            // button_multiplication
            // 
            this.button_multiplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_multiplication.Location = new System.Drawing.Point(0, 108);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(284, 33);
            this.button_multiplication.TabIndex = 3;
            this.button_multiplication.Text = "Multiplication";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_result.Location = new System.Drawing.Point(0, 141);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(284, 121);
            this.textBox_result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.textBox_dc);
            this.Controls.Add(this.textBox_ab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ab;
        private System.Windows.Forms.TextBox textBox_dc;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

