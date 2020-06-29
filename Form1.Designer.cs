namespace StringFormater
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
            this.n_tb = new System.Windows.Forms.TextBox();
            this.n_lab = new System.Windows.Forms.Label();
            this.s_lab = new System.Windows.Forms.Label();
            this.s_tb = new System.Windows.Forms.TextBox();
            this.ot_lab = new System.Windows.Forms.Label();
            this.ot_tb = new System.Windows.Forms.TextBox();
            this.in_lab = new System.Windows.Forms.Label();
            this.in_tb = new System.Windows.Forms.TextBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n_tb
            // 
            this.n_tb.Location = new System.Drawing.Point(75, 101);
            this.n_tb.Name = "n_tb";
            this.n_tb.Size = new System.Drawing.Size(123, 20);
            this.n_tb.TabIndex = 0;
            // 
            // n_lab
            // 
            this.n_lab.AutoSize = true;
            this.n_lab.Location = new System.Drawing.Point(37, 104);
            this.n_lab.Name = "n_lab";
            this.n_lab.Size = new System.Drawing.Size(32, 13);
            this.n_lab.TabIndex = 1;
            this.n_lab.Text = "Имя:";
            // 
            // s_lab
            // 
            this.s_lab.AutoSize = true;
            this.s_lab.Location = new System.Drawing.Point(17, 126);
            this.s_lab.Name = "s_lab";
            this.s_lab.Size = new System.Drawing.Size(59, 13);
            this.s_lab.TabIndex = 3;
            this.s_lab.Text = "Фамилия:";
            // 
            // s_tb
            // 
            this.s_tb.Location = new System.Drawing.Point(75, 123);
            this.s_tb.Name = "s_tb";
            this.s_tb.Size = new System.Drawing.Size(123, 20);
            this.s_tb.TabIndex = 2;
            // 
            // ot_lab
            // 
            this.ot_lab.AutoSize = true;
            this.ot_lab.Location = new System.Drawing.Point(19, 151);
            this.ot_lab.Name = "ot_lab";
            this.ot_lab.Size = new System.Drawing.Size(57, 13);
            this.ot_lab.TabIndex = 5;
            this.ot_lab.Text = "Отчество:";
            // 
            // ot_tb
            // 
            this.ot_tb.Location = new System.Drawing.Point(75, 148);
            this.ot_tb.Name = "ot_tb";
            this.ot_tb.Size = new System.Drawing.Size(123, 20);
            this.ot_tb.TabIndex = 4;
            // 
            // in_lab
            // 
            this.in_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.in_lab.Location = new System.Drawing.Point(120, 211);
            this.in_lab.Name = "in_lab";
            this.in_lab.Size = new System.Drawing.Size(120, 40);
            this.in_lab.TabIndex = 6;
            this.in_lab.Text = "Инициалы:";
            this.in_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // in_tb
            // 
            this.in_tb.BackColor = System.Drawing.SystemColors.Info;
            this.in_tb.Location = new System.Drawing.Point(123, 254);
            this.in_tb.Name = "in_tb";
            this.in_tb.ReadOnly = true;
            this.in_tb.Size = new System.Drawing.Size(113, 20);
            this.in_tb.TabIndex = 7;
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.Blue;
            this.go_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.go_btn.FlatAppearance.BorderSize = 3;
            this.go_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_btn.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_btn.ForeColor = System.Drawing.Color.Yellow;
            this.go_btn.Location = new System.Drawing.Point(241, 112);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(65, 39);
            this.go_btn.TabIndex = 8;
            this.go_btn.Text = "GO";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // lab
            // 
            this.lab.Font = new System.Drawing.Font("Cinzel Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.Red;
            this.lab.Location = new System.Drawing.Point(33, 31);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(292, 54);
            this.lab.TabIndex = 9;
            this.lab.Text = "StringFormater";
            this.lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.in_tb);
            this.Controls.Add(this.in_lab);
            this.Controls.Add(this.ot_lab);
            this.Controls.Add(this.ot_tb);
            this.Controls.Add(this.s_lab);
            this.Controls.Add(this.s_tb);
            this.Controls.Add(this.n_lab);
            this.Controls.Add(this.n_tb);
            this.Name = "Form1";
            this.Text = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n_tb;
        private System.Windows.Forms.Label n_lab;
        private System.Windows.Forms.Label s_lab;
        private System.Windows.Forms.TextBox s_tb;
        private System.Windows.Forms.Label ot_lab;
        private System.Windows.Forms.TextBox ot_tb;
        private System.Windows.Forms.Label in_lab;
        private System.Windows.Forms.TextBox in_tb;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label lab;
    }
}

