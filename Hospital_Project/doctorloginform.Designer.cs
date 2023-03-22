namespace Hospital_Project
{
    partial class doctorloginform
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
            this.btnDlogin = new System.Windows.Forms.Button();
            this.txtbDLpassword = new System.Windows.Forms.TextBox();
            this.mtxtbDLidf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblDLmainpage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnDlogin
            // 
            this.btnDlogin.Location = new System.Drawing.Point(267, 151);
            this.btnDlogin.Name = "btnDlogin";
            this.btnDlogin.Size = new System.Drawing.Size(83, 32);
            this.btnDlogin.TabIndex = 13;
            this.btnDlogin.Text = "Login";
            this.btnDlogin.UseVisualStyleBackColor = true;
            this.btnDlogin.Click += new System.EventHandler(this.btnDlogin_Click);
            // 
            // txtbDLpassword
            // 
            this.txtbDLpassword.Location = new System.Drawing.Point(239, 116);
            this.txtbDLpassword.Name = "txtbDLpassword";
            this.txtbDLpassword.Size = new System.Drawing.Size(111, 29);
            this.txtbDLpassword.TabIndex = 11;
            this.txtbDLpassword.UseSystemPasswordChar = true;
            // 
            // mtxtbDLidf
            // 
            this.mtxtbDLidf.Location = new System.Drawing.Point(239, 75);
            this.mtxtbDLidf.Mask = "00000000";
            this.mtxtbDLidf.Name = "mtxtbDLidf";
            this.mtxtbDLidf.Size = new System.Drawing.Size(111, 29);
            this.mtxtbDLidf.TabIndex = 10;
            this.mtxtbDLidf.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(151, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doctor Identification:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor login panel";
            // 
            // lnklblDLmainpage
            // 
            this.lnklblDLmainpage.AutoSize = true;
            this.lnklblDLmainpage.Location = new System.Drawing.Point(356, 83);
            this.lnklblDLmainpage.Name = "lnklblDLmainpage";
            this.lnklblDLmainpage.Size = new System.Drawing.Size(87, 21);
            this.lnklblDLmainpage.TabIndex = 18;
            this.lnklblDLmainpage.TabStop = true;
            this.lnklblDLmainpage.Text = "Main page";
            this.lnklblDLmainpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblDLmainpage_LinkClicked);
            // 
            // doctorloginform
            // 
            this.AcceptButton = this.btnDlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(461, 201);
            this.Controls.Add(this.lnklblDLmainpage);
            this.Controls.Add(this.btnDlogin);
            this.Controls.Add(this.txtbDLpassword);
            this.Controls.Add(this.mtxtbDLidf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "doctorloginform";
            this.Text = "Doctor login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDlogin;
        private System.Windows.Forms.TextBox txtbDLpassword;
        private System.Windows.Forms.MaskedTextBox mtxtbDLidf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblDLmainpage;
    }
}