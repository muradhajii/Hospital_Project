namespace Hospital_Project
{
    partial class patientinfoform
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
            this.grpbPI = new System.Windows.Forms.GroupBox();
            this.lblPIfname = new System.Windows.Forms.Label();
            this.lblPIidnum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbPIappointment = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linklblPIeditp = new System.Windows.Forms.LinkLabel();
            this.btnPIappointment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtbPIdisease = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPIdoctor = new System.Windows.Forms.ComboBox();
            this.cmbPIbranch = new System.Windows.Forms.ComboBox();
            this.grpbPIapphist = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbPIactiveapp = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtbPIid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbPI.SuspendLayout();
            this.grpbPIappointment.SuspendLayout();
            this.grpbPIapphist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbPIactiveapp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbPI
            // 
            this.grpbPI.Controls.Add(this.lblPIfname);
            this.grpbPI.Controls.Add(this.lblPIidnum);
            this.grpbPI.Controls.Add(this.label2);
            this.grpbPI.Controls.Add(this.label1);
            this.grpbPI.Location = new System.Drawing.Point(5, 5);
            this.grpbPI.Name = "grpbPI";
            this.grpbPI.Size = new System.Drawing.Size(259, 134);
            this.grpbPI.TabIndex = 0;
            this.grpbPI.TabStop = false;
            this.grpbPI.Text = "Patient Info";
            // 
            // lblPIfname
            // 
            this.lblPIfname.AutoSize = true;
            this.lblPIfname.Location = new System.Drawing.Point(94, 75);
            this.lblPIfname.Name = "lblPIfname";
            this.lblPIfname.Size = new System.Drawing.Size(67, 21);
            this.lblPIfname.TabIndex = 3;
            this.lblPIfname.Text = "null null";
            // 
            // lblPIidnum
            // 
            this.lblPIidnum.AutoSize = true;
            this.lblPIidnum.Location = new System.Drawing.Point(94, 36);
            this.lblPIidnum.Name = "lblPIidnum";
            this.lblPIidnum.Size = new System.Drawing.Size(82, 21);
            this.lblPIidnum.TabIndex = 2;
            this.lblPIidnum.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID num:";
            // 
            // grpbPIappointment
            // 
            this.grpbPIappointment.Controls.Add(this.label3);
            this.grpbPIappointment.Controls.Add(this.txtbPIid);
            this.grpbPIappointment.Controls.Add(this.linkLabel1);
            this.grpbPIappointment.Controls.Add(this.linklblPIeditp);
            this.grpbPIappointment.Controls.Add(this.btnPIappointment);
            this.grpbPIappointment.Controls.Add(this.label7);
            this.grpbPIappointment.Controls.Add(this.rtxtbPIdisease);
            this.grpbPIappointment.Controls.Add(this.label6);
            this.grpbPIappointment.Controls.Add(this.label5);
            this.grpbPIappointment.Controls.Add(this.cmbPIdoctor);
            this.grpbPIappointment.Controls.Add(this.cmbPIbranch);
            this.grpbPIappointment.Location = new System.Drawing.Point(5, 145);
            this.grpbPIappointment.Name = "grpbPIappointment";
            this.grpbPIappointment.Size = new System.Drawing.Size(259, 252);
            this.grpbPIappointment.TabIndex = 1;
            this.grpbPIappointment.TabStop = false;
            this.grpbPIappointment.Text = "Appointment";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(6, 178);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Main page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linklblPIeditp
            // 
            this.linklblPIeditp.AutoSize = true;
            this.linklblPIeditp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblPIeditp.Location = new System.Drawing.Point(6, 216);
            this.linklblPIeditp.Name = "linklblPIeditp";
            this.linklblPIeditp.Size = new System.Drawing.Size(75, 19);
            this.linklblPIeditp.TabIndex = 7;
            this.linklblPIeditp.TabStop = true;
            this.linklblPIeditp.Text = "Edit profile";
            this.linklblPIeditp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPIeditp_LinkClicked);
            // 
            // btnPIappointment
            // 
            this.btnPIappointment.Location = new System.Drawing.Point(88, 204);
            this.btnPIappointment.Name = "btnPIappointment";
            this.btnPIappointment.Size = new System.Drawing.Size(121, 31);
            this.btnPIappointment.TabIndex = 5;
            this.btnPIappointment.Text = "Appointment";
            this.btnPIappointment.UseVisualStyleBackColor = true;
            this.btnPIappointment.Click += new System.EventHandler(this.btnPIappointment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Disease:";
            // 
            // rtxtbPIdisease
            // 
            this.rtxtbPIdisease.Location = new System.Drawing.Point(88, 126);
            this.rtxtbPIdisease.Name = "rtxtbPIdisease";
            this.rtxtbPIdisease.Size = new System.Drawing.Size(121, 61);
            this.rtxtbPIdisease.TabIndex = 4;
            this.rtxtbPIdisease.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branch:";
            // 
            // cmbPIdoctor
            // 
            this.cmbPIdoctor.FormattingEnabled = true;
            this.cmbPIdoctor.Location = new System.Drawing.Point(88, 91);
            this.cmbPIdoctor.Name = "cmbPIdoctor";
            this.cmbPIdoctor.Size = new System.Drawing.Size(121, 29);
            this.cmbPIdoctor.TabIndex = 3;
            this.cmbPIdoctor.SelectedIndexChanged += new System.EventHandler(this.cmbPIdoctor_SelectedIndexChanged);
            // 
            // cmbPIbranch
            // 
            this.cmbPIbranch.FormattingEnabled = true;
            this.cmbPIbranch.Location = new System.Drawing.Point(88, 56);
            this.cmbPIbranch.Name = "cmbPIbranch";
            this.cmbPIbranch.Size = new System.Drawing.Size(121, 29);
            this.cmbPIbranch.TabIndex = 2;
            this.cmbPIbranch.SelectedIndexChanged += new System.EventHandler(this.cmbPIbranch_SelectedIndexChanged);
            // 
            // grpbPIapphist
            // 
            this.grpbPIapphist.Controls.Add(this.dataGridView1);
            this.grpbPIapphist.Location = new System.Drawing.Point(267, 5);
            this.grpbPIapphist.Name = "grpbPIapphist";
            this.grpbPIapphist.Size = new System.Drawing.Size(730, 197);
            this.grpbPIapphist.TabIndex = 2;
            this.grpbPIapphist.TabStop = false;
            this.grpbPIapphist.Text = "Appointment history";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpbPIactiveapp
            // 
            this.grpbPIactiveapp.Controls.Add(this.dataGridView2);
            this.grpbPIactiveapp.Location = new System.Drawing.Point(267, 201);
            this.grpbPIactiveapp.Name = "grpbPIactiveapp";
            this.grpbPIactiveapp.Size = new System.Drawing.Size(730, 197);
            this.grpbPIactiveapp.TabIndex = 3;
            this.grpbPIactiveapp.TabStop = false;
            this.grpbPIactiveapp.Text = "Active appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(724, 169);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txtbPIid
            // 
            this.txtbPIid.Enabled = false;
            this.txtbPIid.Location = new System.Drawing.Point(88, 21);
            this.txtbPIid.Name = "txtbPIid";
            this.txtbPIid.Size = new System.Drawing.Size(121, 29);
            this.txtbPIid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // patientinfoform
            // 
            this.AcceptButton = this.btnPIappointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1005, 409);
            this.Controls.Add(this.grpbPIactiveapp);
            this.Controls.Add(this.grpbPIapphist);
            this.Controls.Add(this.grpbPIappointment);
            this.Controls.Add(this.grpbPI);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "patientinfoform";
            this.Text = "Patient Info";
            this.Load += new System.EventHandler(this.patientinfoform_Load);
            this.grpbPI.ResumeLayout(false);
            this.grpbPI.PerformLayout();
            this.grpbPIappointment.ResumeLayout(false);
            this.grpbPIappointment.PerformLayout();
            this.grpbPIapphist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbPIactiveapp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPI;
        private System.Windows.Forms.Label lblPIfname;
        private System.Windows.Forms.Label lblPIidnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbPIappointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtbPIdisease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPIdoctor;
        private System.Windows.Forms.ComboBox cmbPIbranch;
        private System.Windows.Forms.Button btnPIappointment;
        private System.Windows.Forms.GroupBox grpbPIapphist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbPIactiveapp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linklblPIeditp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPIid;
    }
}