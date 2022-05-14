namespace CalcForms
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.calcbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox1.Location = new System.Drawing.Point(14, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "100000";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 74);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма кредиту/займу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Відсоткова ставка, % річних";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 74);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox2.Location = new System.Drawing.Point(14, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "4";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Строк кредиту/займу (в місяцях).";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(3, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 74);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox3.Location = new System.Drawing.Point(14, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 26);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "18";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.savebtn.ForeColor = System.Drawing.Color.SlateGray;
            this.savebtn.Location = new System.Drawing.Point(122, 323);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(120, 37);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Зберегти";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // calcbtn
            // 
            this.calcbtn.BackColor = System.Drawing.Color.SlateGray;
            this.calcbtn.FlatAppearance.BorderSize = 0;
            this.calcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcbtn.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.calcbtn.ForeColor = System.Drawing.Color.White;
            this.calcbtn.Location = new System.Drawing.Point(3, 323);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(113, 37);
            this.calcbtn.TabIndex = 8;
            this.calcbtn.Text = "Порахувати";
            this.calcbtn.UseVisualStyleBackColor = false;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(3, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 74);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Результат";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.SlateGray;
            this.textBox4.Location = new System.Drawing.Point(14, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 26);
            this.textBox4.TabIndex = 1;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 363);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.Leave += new System.EventHandler(this.Deposit_Leave);
            this.MouseLeave += new System.EventHandler(this.Deposit_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Deposit_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

