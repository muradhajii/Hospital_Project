namespace Hospital_Project
{
    partial class patientsignupform
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
            this.txtbPSUsname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPSUpassword = new System.Windows.Forms.TextBox();
            this.mtxtbPSUpidf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPSUname = new System.Windows.Forms.TextBox();
            this.mtxtbPSUphone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPSUsex = new System.Windows.Forms.ComboBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbPSUsname
            // 
            this.txtbPSUsname.Location = new System.Drawing.Point(172, 47);
            this.txtbPSUsname.Name = "txtbPSUsname";
            this.txtbPSUsname.Size = new System.Drawing.Size(173, 29);
            this.txtbPSUsname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(87, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txtbPSUpassword
            // 
            this.txtbPSUpassword.Location = new System.Drawing.Point(172, 152);
            this.txtbPSUpassword.Name = "txtbPSUpassword";
            this.txtbPSUpassword.Size = new System.Drawing.Size(173, 29);
            this.txtbPSUpassword.TabIndex = 5;
            // 
            // mtxtbPSUpidf
            // 
            this.mtxtbPSUpidf.Location = new System.Drawing.Point(172, 82);
            this.mtxtbPSUpidf.Mask = "00000000";
            this.mtxtbPSUpidf.Name = "mtxtbPSUpidf";
            this.mtxtbPSUpidf.Size = new System.Drawing.Size(173, 29);
            this.mtxtbPSUpidf.TabIndex = 3;
            this.mtxtbPSUpidf.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(84, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient Identification:";
            // 
            // txtbPSUname
            // 
            this.txtbPSUname.Location = new System.Drawing.Point(172, 12);
            this.txtbPSUname.Name = "txtbPSUname";
            this.txtbPSUname.Size = new System.Drawing.Size(173, 29);
            this.txtbPSUname.TabIndex = 1;
            // 
            // mtxtbPSUphone
            // 
            this.mtxtbPSUphone.Location = new System.Drawing.Point(172, 117);
            this.mtxtbPSUphone.Mask = "(999) 00-000-0000";
            this.mtxtbPSUphone.Name = "mtxtbPSUphone";
            this.mtxtbPSUphone.Size = new System.Drawing.Size(173, 29);
            this.mtxtbPSUphone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(105, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(130, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sex:";
            // 
            // cmbPSUsex
            // 
            this.cmbPSUsex.FormattingEnabled = true;
            this.cmbPSUsex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Neutral"});
            this.cmbPSUsex.Location = new System.Drawing.Point(172, 187);
            this.cmbPSUsex.Name = "cmbPSUsex";
            this.cmbPSUsex.Size = new System.Drawing.Size(173, 29);
            this.cmbPSUsex.TabIndex = 6;
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(234, 222);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(111, 30);
            this.btnsignup.TabIndex = 7;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // patientsignupform
            // 
            this.AcceptButton = this.btnsignup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(357, 274);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.cmbPSUsex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtbPSUphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbPSUname);
            this.Controls.Add(this.txtbPSUpassword);
            this.Controls.Add(this.mtxtbPSUpidf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbPSUsname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "patientsignupform";
            this.Text = "Patient Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPSUsname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPSUpassword;
        private System.Windows.Forms.MaskedTextBox mtxtbPSUpidf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPSUname;
        private System.Windows.Forms.MaskedTextBox mtxtbPSUphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPSUsex;
        private System.Windows.Forms.Button btnsignup;
    }
}