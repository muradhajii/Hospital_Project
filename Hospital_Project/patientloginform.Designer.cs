namespace Hospital_Project
{
    partial class patientloginform
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
            this.mtxtbPLidf = new System.Windows.Forms.MaskedTextBox();
            this.txtbPLpassword = new System.Windows.Forms.TextBox();
            this.linkPlbl = new System.Windows.Forms.LinkLabel();
            this.btnPlogin = new System.Windows.Forms.Button();
            this.lnklblPLmainpage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient login panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Identification:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(134, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // mtxtbPLidf
            // 
            this.mtxtbPLidf.Location = new System.Drawing.Point(222, 64);
            this.mtxtbPLidf.Mask = "00000000";
            this.mtxtbPLidf.Name = "mtxtbPLidf";
            this.mtxtbPLidf.Size = new System.Drawing.Size(111, 29);
            this.mtxtbPLidf.TabIndex = 1;
            this.mtxtbPLidf.ValidatingType = typeof(int);
            // 
            // txtbPLpassword
            // 
            this.txtbPLpassword.Location = new System.Drawing.Point(222, 105);
            this.txtbPLpassword.Name = "txtbPLpassword";
            this.txtbPLpassword.Size = new System.Drawing.Size(111, 29);
            this.txtbPLpassword.TabIndex = 2;
            this.txtbPLpassword.UseSystemPasswordChar = true;
            // 
            // linkPlbl
            // 
            this.linkPlbl.AutoSize = true;
            this.linkPlbl.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkPlbl.Location = new System.Drawing.Point(339, 113);
            this.linkPlbl.Name = "linkPlbl";
            this.linkPlbl.Size = new System.Drawing.Size(67, 21);
            this.linkPlbl.TabIndex = 5;
            this.linkPlbl.TabStop = true;
            this.linkPlbl.Text = "Sign up";
            this.linkPlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlbl_LinkClicked);
            // 
            // btnPlogin
            // 
            this.btnPlogin.Location = new System.Drawing.Point(250, 140);
            this.btnPlogin.Name = "btnPlogin";
            this.btnPlogin.Size = new System.Drawing.Size(83, 32);
            this.btnPlogin.TabIndex = 3;
            this.btnPlogin.Text = "Login";
            this.btnPlogin.UseVisualStyleBackColor = true;
            this.btnPlogin.Click += new System.EventHandler(this.btnPlogin_Click);
            // 
            // lnklblPLmainpage
            // 
            this.lnklblPLmainpage.AutoSize = true;
            this.lnklblPLmainpage.Location = new System.Drawing.Point(339, 72);
            this.lnklblPLmainpage.Name = "lnklblPLmainpage";
            this.lnklblPLmainpage.Size = new System.Drawing.Size(87, 21);
            this.lnklblPLmainpage.TabIndex = 18;
            this.lnklblPLmainpage.TabStop = true;
            this.lnklblPLmainpage.Text = "Main page";
            this.lnklblPLmainpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblPLmainpage_LinkClicked);
            // 
            // patientloginform
            // 
            this.AcceptButton = this.btnPlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(471, 200);
            this.Controls.Add(this.lnklblPLmainpage);
            this.Controls.Add(this.btnPlogin);
            this.Controls.Add(this.linkPlbl);
            this.Controls.Add(this.txtbPLpassword);
            this.Controls.Add(this.mtxtbPLidf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "patientloginform";
            this.Text = "Patient login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtbPLidf;
        private System.Windows.Forms.TextBox txtbPLpassword;
        private System.Windows.Forms.LinkLabel linkPlbl;
        private System.Windows.Forms.Button btnPlogin;
        private System.Windows.Forms.LinkLabel lnklblPLmainpage;
    }
}