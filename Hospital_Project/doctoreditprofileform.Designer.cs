namespace Hospital_Project
{
    partial class doctoreditprofileform
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
            this.btnDEPupdate = new System.Windows.Forms.Button();
            this.mtxtbDEPphone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbDEPname = new System.Windows.Forms.TextBox();
            this.txtbDEPpassword = new System.Windows.Forms.TextBox();
            this.mtxtbDEPpidf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDEPsname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDEPbranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDEPupdate
            // 
            this.btnDEPupdate.Location = new System.Drawing.Point(234, 223);
            this.btnDEPupdate.Name = "btnDEPupdate";
            this.btnDEPupdate.Size = new System.Drawing.Size(102, 30);
            this.btnDEPupdate.TabIndex = 7;
            this.btnDEPupdate.Text = "Update";
            this.btnDEPupdate.UseVisualStyleBackColor = true;
            this.btnDEPupdate.Click += new System.EventHandler(this.btnDEPupdate_Click);
            // 
            // mtxtbDEPphone
            // 
            this.mtxtbDEPphone.Location = new System.Drawing.Point(172, 152);
            this.mtxtbDEPphone.Mask = "(999) 00-000-0000";
            this.mtxtbDEPphone.Name = "mtxtbDEPphone";
            this.mtxtbDEPphone.Size = new System.Drawing.Size(164, 29);
            this.mtxtbDEPphone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(110, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Phone:";
            // 
            // txtbDEPname
            // 
            this.txtbDEPname.Location = new System.Drawing.Point(172, 12);
            this.txtbDEPname.Name = "txtbDEPname";
            this.txtbDEPname.Size = new System.Drawing.Size(164, 29);
            this.txtbDEPname.TabIndex = 1;
            // 
            // txtbDEPpassword
            // 
            this.txtbDEPpassword.Location = new System.Drawing.Point(172, 187);
            this.txtbDEPpassword.Name = "txtbDEPpassword";
            this.txtbDEPpassword.Size = new System.Drawing.Size(164, 29);
            this.txtbDEPpassword.TabIndex = 6;
            // 
            // mtxtbDEPpidf
            // 
            this.mtxtbDEPpidf.Location = new System.Drawing.Point(172, 82);
            this.mtxtbDEPpidf.Mask = "00000000";
            this.mtxtbDEPpidf.Name = "mtxtbDEPpidf";
            this.mtxtbDEPpidf.Size = new System.Drawing.Size(164, 29);
            this.mtxtbDEPpidf.TabIndex = 3;
            this.mtxtbDEPpidf.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(83, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(2, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Doctor Identification:";
            // 
            // txtbDEPsname
            // 
            this.txtbDEPsname.Location = new System.Drawing.Point(172, 47);
            this.txtbDEPsname.Name = "txtbDEPsname";
            this.txtbDEPsname.Size = new System.Drawing.Size(164, 29);
            this.txtbDEPsname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(92, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(114, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name:";
            // 
            // cmbDEPbranch
            // 
            this.cmbDEPbranch.FormattingEnabled = true;
            this.cmbDEPbranch.Location = new System.Drawing.Point(172, 117);
            this.cmbDEPbranch.Name = "cmbDEPbranch";
            this.cmbDEPbranch.Size = new System.Drawing.Size(164, 29);
            this.cmbDEPbranch.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(104, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Branch:";
            // 
            // doctoreditprofileform
            // 
            this.AcceptButton = this.btnDEPupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(345, 282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDEPbranch);
            this.Controls.Add(this.btnDEPupdate);
            this.Controls.Add(this.mtxtbDEPphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbDEPname);
            this.Controls.Add(this.txtbDEPpassword);
            this.Controls.Add(this.mtxtbDEPpidf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbDEPsname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "doctoreditprofileform";
            this.Text = "Doctor profile";
            this.Load += new System.EventHandler(this.doctoreditprofileform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDEPupdate;
        private System.Windows.Forms.MaskedTextBox mtxtbDEPphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbDEPname;
        private System.Windows.Forms.TextBox txtbDEPpassword;
        private System.Windows.Forms.MaskedTextBox mtxtbDEPpidf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDEPsname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDEPbranch;
        private System.Windows.Forms.Label label6;
    }
}