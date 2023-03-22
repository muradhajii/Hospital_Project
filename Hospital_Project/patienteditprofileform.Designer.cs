namespace Hospital_Project
{
    partial class patienteditprofileform
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
            this.btnPEPupdate = new System.Windows.Forms.Button();
            this.mtxtbPEPphone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbPEPname = new System.Windows.Forms.TextBox();
            this.txtbPEPpassword = new System.Windows.Forms.TextBox();
            this.mtxtbPEPpidf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPEPsname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPEPupdate
            // 
            this.btnPEPupdate.Location = new System.Drawing.Point(235, 187);
            this.btnPEPupdate.Name = "btnPEPupdate";
            this.btnPEPupdate.Size = new System.Drawing.Size(89, 30);
            this.btnPEPupdate.TabIndex = 6;
            this.btnPEPupdate.Text = "Update";
            this.btnPEPupdate.UseVisualStyleBackColor = true;
            this.btnPEPupdate.Click += new System.EventHandler(this.btnPEPupdate_Click);
            // 
            // mtxtbPEPphone
            // 
            this.mtxtbPEPphone.Location = new System.Drawing.Point(173, 117);
            this.mtxtbPEPphone.Mask = "(999) 00-0000000";
            this.mtxtbPEPphone.Name = "mtxtbPEPphone";
            this.mtxtbPEPphone.Size = new System.Drawing.Size(151, 29);
            this.mtxtbPEPphone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(106, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone:";
            // 
            // txtbPEPname
            // 
            this.txtbPEPname.Location = new System.Drawing.Point(173, 12);
            this.txtbPEPname.Name = "txtbPEPname";
            this.txtbPEPname.Size = new System.Drawing.Size(151, 29);
            this.txtbPEPname.TabIndex = 1;
            // 
            // txtbPEPpassword
            // 
            this.txtbPEPpassword.Location = new System.Drawing.Point(173, 152);
            this.txtbPEPpassword.Name = "txtbPEPpassword";
            this.txtbPEPpassword.Size = new System.Drawing.Size(151, 29);
            this.txtbPEPpassword.TabIndex = 5;
            // 
            // mtxtbPEPpidf
            // 
            this.mtxtbPEPpidf.Location = new System.Drawing.Point(173, 82);
            this.mtxtbPEPpidf.Mask = "00000000";
            this.mtxtbPEPpidf.Name = "mtxtbPEPpidf";
            this.mtxtbPEPpidf.Size = new System.Drawing.Size(151, 29);
            this.mtxtbPEPpidf.TabIndex = 3;
            this.mtxtbPEPpidf.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(85, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Patient Identification:";
            // 
            // txtbPEPsname
            // 
            this.txtbPEPsname.Location = new System.Drawing.Point(173, 47);
            this.txtbPEPsname.Name = "txtbPEPsname";
            this.txtbPEPsname.Size = new System.Drawing.Size(151, 29);
            this.txtbPEPsname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(88, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(110, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // patienteditprofileform
            // 
            this.AcceptButton = this.btnPEPupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(332, 228);
            this.Controls.Add(this.btnPEPupdate);
            this.Controls.Add(this.mtxtbPEPphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbPEPname);
            this.Controls.Add(this.txtbPEPpassword);
            this.Controls.Add(this.mtxtbPEPpidf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbPEPsname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "patienteditprofileform";
            this.Text = "Patient profile update";
            this.Load += new System.EventHandler(this.patienteditprofileform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPEPupdate;
        private System.Windows.Forms.MaskedTextBox mtxtbPEPphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbPEPname;
        private System.Windows.Forms.TextBox txtbPEPpassword;
        private System.Windows.Forms.MaskedTextBox mtxtbPEPpidf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPEPsname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}