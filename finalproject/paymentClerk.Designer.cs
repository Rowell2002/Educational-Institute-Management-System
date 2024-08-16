namespace finalproject
{
    partial class paymentClerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentClerk));
            this.pnl_pay = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_empSal = new System.Windows.Forms.Button();
            this.btn_payConf = new System.Windows.Forms.Button();
            this.btn_addpd = new System.Windows.Forms.Button();
            this.btn_payStatus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_pay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_pay
            // 
            this.pnl_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.pnl_pay.Controls.Add(this.label2);
            this.pnl_pay.Controls.Add(this.pictureBox3);
            this.pnl_pay.Controls.Add(this.pictureBox2);
            this.pnl_pay.Controls.Add(this.lbl_pc);
            this.pnl_pay.Controls.Add(this.label1);
            this.pnl_pay.Controls.Add(this.pictureBox1);
            this.pnl_pay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pay.Location = new System.Drawing.Point(0, 0);
            this.pnl_pay.Name = "pnl_pay";
            this.pnl_pay.Size = new System.Drawing.Size(1293, 93);
            this.pnl_pay.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(76, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc.ForeColor = System.Drawing.Color.Silver;
            this.lbl_pc.Location = new System.Drawing.Point(962, 58);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(66, 24);
            this.lbl_pc.TabIndex = 3;
            this.lbl_pc.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(944, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Clerk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_empSal);
            this.panel1.Controls.Add(this.btn_payConf);
            this.panel1.Controls.Add(this.btn_addpd);
            this.panel1.Controls.Add(this.btn_payStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 4;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_logout.Location = new System.Drawing.Point(12, 491);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(174, 69);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_empSal
            // 
            this.btn_empSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_empSal.FlatAppearance.BorderSize = 0;
            this.btn_empSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empSal.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_empSal.Location = new System.Drawing.Point(12, 384);
            this.btn_empSal.Name = "btn_empSal";
            this.btn_empSal.Size = new System.Drawing.Size(174, 69);
            this.btn_empSal.TabIndex = 16;
            this.btn_empSal.Text = "Employee Salary";
            this.btn_empSal.UseVisualStyleBackColor = false;
            this.btn_empSal.Click += new System.EventHandler(this.btn_empSal_Click);
            // 
            // btn_payConf
            // 
            this.btn_payConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_payConf.FlatAppearance.BorderSize = 0;
            this.btn_payConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payConf.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_payConf.Location = new System.Drawing.Point(12, 273);
            this.btn_payConf.Name = "btn_payConf";
            this.btn_payConf.Size = new System.Drawing.Size(174, 69);
            this.btn_payConf.TabIndex = 13;
            this.btn_payConf.Text = "Payment Confirmation";
            this.btn_payConf.UseVisualStyleBackColor = false;
            this.btn_payConf.Click += new System.EventHandler(this.btn_payConf_Click);
            // 
            // btn_addpd
            // 
            this.btn_addpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_addpd.FlatAppearance.BorderSize = 0;
            this.btn_addpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addpd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_addpd.Location = new System.Drawing.Point(12, 162);
            this.btn_addpd.Name = "btn_addpd";
            this.btn_addpd.Size = new System.Drawing.Size(174, 69);
            this.btn_addpd.TabIndex = 12;
            this.btn_addpd.Text = "Add Payment Details";
            this.btn_addpd.UseVisualStyleBackColor = false;
            this.btn_addpd.Click += new System.EventHandler(this.btn_updateAcc_Click);
            // 
            // btn_payStatus
            // 
            this.btn_payStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_payStatus.FlatAppearance.BorderSize = 0;
            this.btn_payStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payStatus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_payStatus.Location = new System.Drawing.Point(12, 53);
            this.btn_payStatus.Name = "btn_payStatus";
            this.btn_payStatus.Size = new System.Drawing.Size(174, 69);
            this.btn_payStatus.TabIndex = 11;
            this.btn_payStatus.Text = "Payment Status";
            this.btn_payStatus.UseVisualStyleBackColor = false;
            this.btn_payStatus.Click += new System.EventHandler(this.btn_payStatus_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 622);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(572, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "31/05/2024";
            // 
            // paymentClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_pay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentClerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentClerk";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.paymentClerk_Load);
            this.pnl_pay.ResumeLayout(false);
            this.pnl_pay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_empSal;
        private System.Windows.Forms.Button btn_payConf;
        private System.Windows.Forms.Button btn_addpd;
        private System.Windows.Forms.Button btn_payStatus;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label2;
    }
}