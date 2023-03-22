namespace Hospital_Project
{
    partial class secretaryloginform
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
            this.btnSlogin = new System.Windows.Forms.Button();
            this.txtbSLpassword = new System.Windows.Forms.TextBox();
            this.mtxtbSLidf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblSLmainpage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSlogin
            // 
            this.btnSlogin.Location = new System.Drawing.Point(267, 151);
            this.btnSlogin.Name = "btnSlogin";
            this.btnSlogin.Size = new System.Drawing.Size(83, 32);
            this.btnSlogin.TabIndex = 3;
            this.btnSlogin.Text = "Login";
            this.btnSlogin.UseVisualStyleBackColor = true;
            this.btnSlogin.Click += new System.EventHandler(this.btnSlogin_Click);
            // 
            // txtbSLpassword
            // 
            this.txtbSLpassword.Location = new System.Drawing.Point(239, 116);
            this.txtbSLpassword.Name = "txtbSLpassword";
            this.txtbSLpassword.Size = new System.Drawing.Size(111, 29);
            this.txtbSLpassword.TabIndex = 2;
            this.txtbSLpassword.UseSystemPasswordChar = true;
            // 
            // mtxtbSLidf
            // 
            this.mtxtbSLidf.Location = new System.Drawing.Point(239, 75);
            this.mtxtbSLidf.Mask = "00000000";
            this.mtxtbSLidf.Name = "mtxtbSLidf";
            this.mtxtbSLidf.Size = new System.Drawing.Size(111, 29);
            this.mtxtbSLidf.TabIndex = 1;
            this.mtxtbSLidf.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(151, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Secretary Identification:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "Secretary login panel";
            // 
            // lnklblSLmainpage
            // 
            this.lnklblSLmainpage.AutoSize = true;
            this.lnklblSLmainpage.Location = new System.Drawing.Point(365, 83);
            this.lnklblSLmainpage.Name = "lnklblSLmainpage";
            this.lnklblSLmainpage.Size = new System.Drawing.Size(87, 21);
            this.lnklblSLmainpage.TabIndex = 17;
            this.lnklblSLmainpage.TabStop = true;
            this.lnklblSLmainpage.Text = "Main page";
            this.lnklblSLmainpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSLmainpage_LinkClicked);
            // 
            // secretaryloginform
            // 
            this.AcceptButton = this.btnSlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(527, 197);
            this.Controls.Add(this.lnklblSLmainpage);
            this.Controls.Add(this.btnSlogin);
            this.Controls.Add(this.txtbSLpassword);
            this.Controls.Add(this.mtxtbSLidf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "secretaryloginform";
            this.Text = "Secretary Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlogin;
        private System.Windows.Forms.TextBox txtbSLpassword;
        private System.Windows.Forms.MaskedTextBox mtxtbSLidf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblSLmainpage;
    }
}