namespace EmployeeSalaryCalculation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textTa = new System.Windows.Forms.TextBox();
            this.textDA = new System.Windows.Forms.TextBox();
            this.textPF = new System.Windows.Forms.TextBox();
            this.textGS = new System.Windows.Forms.TextBox();
            this.textHra = new System.Windows.Forms.TextBox();
            this.textBasic = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.ClickCalculate = new System.Windows.Forms.Button();
            this.CmbDept = new System.Windows.Forms.ComboBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empoloyee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "HRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "TA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "DA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "PF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gross Salary";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(256, 25);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(202, 22);
            this.textid.TabIndex = 10;
            this.textid.TextChanged += new System.EventHandler(this.textid_TextChanged);
            // 
            // textTa
            // 
            this.textTa.Enabled = false;
            this.textTa.Location = new System.Drawing.Point(256, 224);
            this.textTa.Name = "textTa";
            this.textTa.Size = new System.Drawing.Size(202, 22);
            this.textTa.TabIndex = 11;
            this.textTa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textDA
            // 
            this.textDA.Enabled = false;
            this.textDA.Location = new System.Drawing.Point(256, 269);
            this.textDA.Name = "textDA";
            this.textDA.Size = new System.Drawing.Size(202, 22);
            this.textDA.TabIndex = 12;
            // 
            // textPF
            // 
            this.textPF.Enabled = false;
            this.textPF.Location = new System.Drawing.Point(256, 327);
            this.textPF.Name = "textPF";
            this.textPF.Size = new System.Drawing.Size(202, 22);
            this.textPF.TabIndex = 13;
            // 
            // textGS
            // 
            this.textGS.Enabled = false;
            this.textGS.Location = new System.Drawing.Point(256, 365);
            this.textGS.Name = "textGS";
            this.textGS.Size = new System.Drawing.Size(202, 22);
            this.textGS.TabIndex = 14;
            this.textGS.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textHra
            // 
            this.textHra.Enabled = false;
            this.textHra.Location = new System.Drawing.Point(256, 179);
            this.textHra.Name = "textHra";
            this.textHra.Size = new System.Drawing.Size(202, 22);
            this.textHra.TabIndex = 16;
            this.textHra.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBasic
            // 
            this.textBasic.Location = new System.Drawing.Point(256, 139);
            this.textBasic.Name = "textBasic";
            this.textBasic.Size = new System.Drawing.Size(202, 22);
            this.textBasic.TabIndex = 17;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(256, 66);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(202, 22);
            this.textName.TabIndex = 19;
            // 
            // ClickCalculate
            // 
            this.ClickCalculate.Location = new System.Drawing.Point(185, 410);
            this.ClickCalculate.Name = "ClickCalculate";
            this.ClickCalculate.Size = new System.Drawing.Size(98, 28);
            this.ClickCalculate.TabIndex = 20;
            this.ClickCalculate.Text = "Calculate";
            this.ClickCalculate.UseVisualStyleBackColor = true;
            this.ClickCalculate.Click += new System.EventHandler(this.ClickCalculate_Click);
            // 
            // CmbDept
            // 
            this.CmbDept.FormattingEnabled = true;
            this.CmbDept.Location = new System.Drawing.Point(256, 104);
            this.CmbDept.Name = "CmbDept";
            this.CmbDept.Size = new System.Drawing.Size(202, 24);
            this.CmbDept.TabIndex = 21;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(372, 410);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(86, 28);
            this.buttonDisplay.TabIndex = 22;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.CmbDept);
            this.Controls.Add(this.ClickCalculate);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textBasic);
            this.Controls.Add(this.textHra);
            this.Controls.Add(this.textGS);
            this.Controls.Add(this.textPF);
            this.Controls.Add(this.textDA);
            this.Controls.Add(this.textTa);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textTa;
        private System.Windows.Forms.TextBox textDA;
        private System.Windows.Forms.TextBox textPF;
        private System.Windows.Forms.TextBox textGS;
        private System.Windows.Forms.TextBox textHra;
        private System.Windows.Forms.TextBox textBasic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button ClickCalculate;
        private System.Windows.Forms.ComboBox CmbDept;
        private System.Windows.Forms.Button buttonDisplay;
    }
}

