namespace Hospital_Project
{
    partial class medicalcenterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicalcenterform));
            this.btnMCdoclogin = new System.Windows.Forms.Button();
            this.btnMCsecrlogin = new System.Windows.Forms.Button();
            this.btnMCpatientlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMCdoclogin
            // 
            this.btnMCdoclogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMCdoclogin.BackgroundImage")));
            this.btnMCdoclogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMCdoclogin.Location = new System.Drawing.Point(17, 197);
            this.btnMCdoclogin.Name = "btnMCdoclogin";
            this.btnMCdoclogin.Size = new System.Drawing.Size(235, 146);
            this.btnMCdoclogin.TabIndex = 0;
            this.btnMCdoclogin.UseVisualStyleBackColor = true;
            this.btnMCdoclogin.Click += new System.EventHandler(this.btnMCdoclogin_Click);
            // 
            // btnMCsecrlogin
            // 
            this.btnMCsecrlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMCsecrlogin.BackgroundImage")));
            this.btnMCsecrlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMCsecrlogin.Location = new System.Drawing.Point(325, 197);
            this.btnMCsecrlogin.Name = "btnMCsecrlogin";
            this.btnMCsecrlogin.Size = new System.Drawing.Size(235, 146);
            this.btnMCsecrlogin.TabIndex = 1;
            this.btnMCsecrlogin.UseVisualStyleBackColor = true;
            this.btnMCsecrlogin.Click += new System.EventHandler(this.btnMCsecrlogin_Click);
            // 
            // btnMCpatientlogin
            // 
            this.btnMCpatientlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMCpatientlogin.BackgroundImage")));
            this.btnMCpatientlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMCpatientlogin.Location = new System.Drawing.Point(633, 197);
            this.btnMCpatientlogin.Name = "btnMCpatientlogin";
            this.btnMCpatientlogin.Size = new System.Drawing.Size(235, 146);
            this.btnMCpatientlogin.TabIndex = 2;
            this.btnMCpatientlogin.UseVisualStyleBackColor = true;
            this.btnMCpatientlogin.Click += new System.EventHandler(this.btnMCpatientlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secretary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 78);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medical Center";
            // 
            // medicalcenterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(881, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMCpatientlogin);
            this.Controls.Add(this.btnMCsecrlogin);
            this.Controls.Add(this.btnMCdoclogin);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "medicalcenterform";
            this.Text = "Medical Center";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMCdoclogin;
        private System.Windows.Forms.Button btnMCsecrlogin;
        private System.Windows.Forms.Button btnMCpatientlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

