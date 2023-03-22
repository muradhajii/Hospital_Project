namespace Hospital_Project
{
    partial class secretarybranchpanform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbSBPname = new System.Windows.Forms.TextBox();
            this.txtbSBPid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSBPupdate = new System.Windows.Forms.Button();
            this.btnSBPremove = new System.Windows.Forms.Button();
            this.btnSBPadd = new System.Windows.Forms.Button();
            this.btnSBPclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 138);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbSBPname
            // 
            this.txtbSBPname.Location = new System.Drawing.Point(128, 51);
            this.txtbSBPname.Name = "txtbSBPname";
            this.txtbSBPname.Size = new System.Drawing.Size(157, 29);
            this.txtbSBPname.TabIndex = 2;
            // 
            // txtbSBPid
            // 
            this.txtbSBPid.Location = new System.Drawing.Point(128, 12);
            this.txtbSBPid.Name = "txtbSBPid";
            this.txtbSBPid.Size = new System.Drawing.Size(157, 29);
            this.txtbSBPid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Branch name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Branch ID:";
            // 
            // btnSBPupdate
            // 
            this.btnSBPupdate.Location = new System.Drawing.Point(127, 121);
            this.btnSBPupdate.Name = "btnSBPupdate";
            this.btnSBPupdate.Size = new System.Drawing.Size(158, 29);
            this.btnSBPupdate.TabIndex = 5;
            this.btnSBPupdate.Text = "Update";
            this.btnSBPupdate.UseVisualStyleBackColor = true;
            this.btnSBPupdate.Click += new System.EventHandler(this.btnSBPupdate_Click);
            // 
            // btnSBPremove
            // 
            this.btnSBPremove.Location = new System.Drawing.Point(203, 86);
            this.btnSBPremove.Name = "btnSBPremove";
            this.btnSBPremove.Size = new System.Drawing.Size(82, 29);
            this.btnSBPremove.TabIndex = 4;
            this.btnSBPremove.Text = "Remove";
            this.btnSBPremove.UseVisualStyleBackColor = true;
            this.btnSBPremove.Click += new System.EventHandler(this.btnSBPremove_Click);
            // 
            // btnSBPadd
            // 
            this.btnSBPadd.Location = new System.Drawing.Point(127, 86);
            this.btnSBPadd.Name = "btnSBPadd";
            this.btnSBPadd.Size = new System.Drawing.Size(82, 29);
            this.btnSBPadd.TabIndex = 3;
            this.btnSBPadd.Text = "Add";
            this.btnSBPadd.UseVisualStyleBackColor = true;
            this.btnSBPadd.Click += new System.EventHandler(this.btnSBPadd_Click);
            // 
            // btnSBPclear
            // 
            this.btnSBPclear.Location = new System.Drawing.Point(12, 92);
            this.btnSBPclear.Name = "btnSBPclear";
            this.btnSBPclear.Size = new System.Drawing.Size(109, 58);
            this.btnSBPclear.TabIndex = 6;
            this.btnSBPclear.Text = "Clear";
            this.btnSBPclear.UseVisualStyleBackColor = true;
            this.btnSBPclear.Click += new System.EventHandler(this.btnSBPclear_Click);
            // 
            // secretarybranchpanform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(671, 167);
            this.Controls.Add(this.btnSBPclear);
            this.Controls.Add(this.btnSBPupdate);
            this.Controls.Add(this.btnSBPremove);
            this.Controls.Add(this.btnSBPadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbSBPname);
            this.Controls.Add(this.txtbSBPid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "secretarybranchpanform";
            this.Text = "Branch panel";
            this.Load += new System.EventHandler(this.secretarybranchpanform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbSBPname;
        private System.Windows.Forms.TextBox txtbSBPid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSBPupdate;
        private System.Windows.Forms.Button btnSBPremove;
        private System.Windows.Forms.Button btnSBPadd;
        private System.Windows.Forms.Button btnSBPclear;
    }
}