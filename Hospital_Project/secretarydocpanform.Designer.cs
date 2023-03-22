namespace Hospital_Project
{
    partial class secretarydocpanform
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
            this.txtbSDPname = new System.Windows.Forms.TextBox();
            this.txtbSDPsname = new System.Windows.Forms.TextBox();
            this.cmbSDPbranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtbSDPidfnum = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbSDPphone = new System.Windows.Forms.MaskedTextBox();
            this.txtbSDPpassword = new System.Windows.Forms.TextBox();
            this.cmbSDPsex = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSDPadd = new System.Windows.Forms.Button();
            this.btnSDPremove = new System.Windows.Forms.Button();
            this.btnSDPupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSDPclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor IDF num:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone:";
            // 
            // txtbSDPname
            // 
            this.txtbSDPname.Location = new System.Drawing.Point(152, 12);
            this.txtbSDPname.Name = "txtbSDPname";
            this.txtbSDPname.Size = new System.Drawing.Size(158, 29);
            this.txtbSDPname.TabIndex = 1;
            // 
            // txtbSDPsname
            // 
            this.txtbSDPsname.Location = new System.Drawing.Point(152, 51);
            this.txtbSDPsname.Name = "txtbSDPsname";
            this.txtbSDPsname.Size = new System.Drawing.Size(158, 29);
            this.txtbSDPsname.TabIndex = 2;
            // 
            // cmbSDPbranch
            // 
            this.cmbSDPbranch.FormattingEnabled = true;
            this.cmbSDPbranch.Location = new System.Drawing.Point(152, 90);
            this.cmbSDPbranch.Name = "cmbSDPbranch";
            this.cmbSDPbranch.Size = new System.Drawing.Size(158, 29);
            this.cmbSDPbranch.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sex:";
            // 
            // mtxtbSDPidfnum
            // 
            this.mtxtbSDPidfnum.Location = new System.Drawing.Point(152, 129);
            this.mtxtbSDPidfnum.Mask = "00000000";
            this.mtxtbSDPidfnum.Name = "mtxtbSDPidfnum";
            this.mtxtbSDPidfnum.Size = new System.Drawing.Size(158, 29);
            this.mtxtbSDPidfnum.TabIndex = 4;
            this.mtxtbSDPidfnum.ValidatingType = typeof(int);
            // 
            // mtxtbSDPphone
            // 
            this.mtxtbSDPphone.Location = new System.Drawing.Point(152, 168);
            this.mtxtbSDPphone.Mask = "(999) 00-000-0000";
            this.mtxtbSDPphone.Name = "mtxtbSDPphone";
            this.mtxtbSDPphone.Size = new System.Drawing.Size(158, 29);
            this.mtxtbSDPphone.TabIndex = 5;
            // 
            // txtbSDPpassword
            // 
            this.txtbSDPpassword.Location = new System.Drawing.Point(152, 207);
            this.txtbSDPpassword.Name = "txtbSDPpassword";
            this.txtbSDPpassword.Size = new System.Drawing.Size(158, 29);
            this.txtbSDPpassword.TabIndex = 6;
            // 
            // cmbSDPsex
            // 
            this.cmbSDPsex.FormattingEnabled = true;
            this.cmbSDPsex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Neutral"});
            this.cmbSDPsex.Location = new System.Drawing.Point(152, 246);
            this.cmbSDPsex.Name = "cmbSDPsex";
            this.cmbSDPsex.Size = new System.Drawing.Size(158, 29);
            this.cmbSDPsex.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 333);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSDPadd
            // 
            this.btnSDPadd.Location = new System.Drawing.Point(140, 281);
            this.btnSDPadd.Name = "btnSDPadd";
            this.btnSDPadd.Size = new System.Drawing.Size(82, 29);
            this.btnSDPadd.TabIndex = 8;
            this.btnSDPadd.Text = "Add";
            this.btnSDPadd.UseVisualStyleBackColor = true;
            this.btnSDPadd.Click += new System.EventHandler(this.btnSDPadd_Click);
            // 
            // btnSDPremove
            // 
            this.btnSDPremove.Location = new System.Drawing.Point(228, 281);
            this.btnSDPremove.Name = "btnSDPremove";
            this.btnSDPremove.Size = new System.Drawing.Size(82, 29);
            this.btnSDPremove.TabIndex = 9;
            this.btnSDPremove.Text = "Remove";
            this.btnSDPremove.UseVisualStyleBackColor = true;
            this.btnSDPremove.Click += new System.EventHandler(this.btnSDPremove_Click);
            // 
            // btnSDPupdate
            // 
            this.btnSDPupdate.Location = new System.Drawing.Point(140, 316);
            this.btnSDPupdate.Name = "btnSDPupdate";
            this.btnSDPupdate.Size = new System.Drawing.Size(82, 29);
            this.btnSDPupdate.TabIndex = 10;
            this.btnSDPupdate.Text = "Update";
            this.btnSDPupdate.UseVisualStyleBackColor = true;
            this.btnSDPupdate.Click += new System.EventHandler(this.btnSDPupdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSDPclear
            // 
            this.btnSDPclear.Location = new System.Drawing.Point(13, 286);
            this.btnSDPclear.Name = "btnSDPclear";
            this.btnSDPclear.Size = new System.Drawing.Size(121, 56);
            this.btnSDPclear.TabIndex = 12;
            this.btnSDPclear.Text = "Clear";
            this.btnSDPclear.UseVisualStyleBackColor = true;
            this.btnSDPclear.Click += new System.EventHandler(this.btnSDPclear_Click);
            // 
            // secretarydocpanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1166, 354);
            this.Controls.Add(this.btnSDPclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSDPupdate);
            this.Controls.Add(this.btnSDPremove);
            this.Controls.Add(this.btnSDPadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbSDPsex);
            this.Controls.Add(this.txtbSDPpassword);
            this.Controls.Add(this.mtxtbSDPphone);
            this.Controls.Add(this.mtxtbSDPidfnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSDPbranch);
            this.Controls.Add(this.txtbSDPsname);
            this.Controls.Add(this.txtbSDPname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "secretarydocpanform";
            this.Text = "Doctor panel";
            this.Load += new System.EventHandler(this.secretarydocpanform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbSDPname;
        private System.Windows.Forms.TextBox txtbSDPsname;
        private System.Windows.Forms.ComboBox cmbSDPbranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtbSDPidfnum;
        private System.Windows.Forms.MaskedTextBox mtxtbSDPphone;
        private System.Windows.Forms.TextBox txtbSDPpassword;
        private System.Windows.Forms.ComboBox cmbSDPsex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSDPadd;
        private System.Windows.Forms.Button btnSDPremove;
        private System.Windows.Forms.Button btnSDPupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSDPclear;
    }
}