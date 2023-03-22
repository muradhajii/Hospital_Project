namespace Hospital_Project
{
    partial class doctorinfoform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDIfname = new System.Windows.Forms.Label();
            this.lblDIidnum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtbDIappdetail = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDIexit = new System.Windows.Forms.Button();
            this.btnDIannounce = new System.Windows.Forms.Button();
            this.btnDIedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDIfname);
            this.groupBox1.Controls.Add(this.lblDIidnum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor info";
            // 
            // lblDIfname
            // 
            this.lblDIfname.AutoSize = true;
            this.lblDIfname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIfname.Location = new System.Drawing.Point(98, 77);
            this.lblDIfname.Name = "lblDIfname";
            this.lblDIfname.Size = new System.Drawing.Size(67, 21);
            this.lblDIfname.TabIndex = 7;
            this.lblDIfname.Text = "null null";
            // 
            // lblDIidnum
            // 
            this.lblDIidnum.AutoSize = true;
            this.lblDIidnum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIidnum.Location = new System.Drawing.Point(98, 38);
            this.lblDIidnum.Name = "lblDIidnum";
            this.lblDIidnum.Size = new System.Drawing.Size(82, 21);
            this.lblDIidnum.TabIndex = 6;
            this.lblDIidnum.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fullname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID num:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtbDIappdetail);
            this.groupBox2.Location = new System.Drawing.Point(5, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment detail";
            // 
            // rtxtbDIappdetail
            // 
            this.rtxtbDIappdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbDIappdetail.Location = new System.Drawing.Point(3, 25);
            this.rtxtbDIappdetail.Name = "rtxtbDIappdetail";
            this.rtxtbDIappdetail.Size = new System.Drawing.Size(258, 186);
            this.rtxtbDIappdetail.TabIndex = 0;
            this.rtxtbDIappdetail.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(275, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 457);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnDIexit);
            this.groupBox4.Controls.Add(this.btnDIannounce);
            this.groupBox4.Controls.Add(this.btnDIedit);
            this.groupBox4.Location = new System.Drawing.Point(5, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick access";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Main page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDIexit
            // 
            this.btnDIexit.Location = new System.Drawing.Point(7, 64);
            this.btnDIexit.Name = "btnDIexit";
            this.btnDIexit.Size = new System.Drawing.Size(121, 30);
            this.btnDIexit.TabIndex = 3;
            this.btnDIexit.Text = "Exit";
            this.btnDIexit.UseVisualStyleBackColor = true;
            this.btnDIexit.Click += new System.EventHandler(this.btnDIexit_Click);
            // 
            // btnDIannounce
            // 
            this.btnDIannounce.Location = new System.Drawing.Point(132, 24);
            this.btnDIannounce.Name = "btnDIannounce";
            this.btnDIannounce.Size = new System.Drawing.Size(126, 30);
            this.btnDIannounce.TabIndex = 1;
            this.btnDIannounce.Text = "Announcments";
            this.btnDIannounce.UseVisualStyleBackColor = true;
            this.btnDIannounce.Click += new System.EventHandler(this.btnDIannounce_Click);
            // 
            // btnDIedit
            // 
            this.btnDIedit.Location = new System.Drawing.Point(6, 24);
            this.btnDIedit.Name = "btnDIedit";
            this.btnDIedit.Size = new System.Drawing.Size(122, 30);
            this.btnDIedit.TabIndex = 0;
            this.btnDIedit.Text = "Edit info";
            this.btnDIedit.UseVisualStyleBackColor = true;
            this.btnDIedit.Click += new System.EventHandler(this.btnDIedit_Click);
            // 
            // doctorinfoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(891, 471);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "doctorinfoform";
            this.Text = "doctorinfoform";
            this.Load += new System.EventHandler(this.doctorinfoform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDIfname;
        private System.Windows.Forms.Label lblDIidnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtbDIappdetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDIexit;
        private System.Windows.Forms.Button btnDIannounce;
        private System.Windows.Forms.Button btnDIedit;
        private System.Windows.Forms.Button button1;
    }
}