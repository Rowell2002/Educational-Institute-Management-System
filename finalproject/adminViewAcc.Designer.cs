namespace finalproject
{
    partial class adminViewAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminViewAcc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addAcc = new System.Windows.Forms.Button();
            this.btn_delAcc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_addAcc);
            this.panel2.Controls.Add(this.btn_delAcc);
            this.panel2.Location = new System.Drawing.Point(317, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 448);
            this.panel2.TabIndex = 18;
            // 
            // btn_addAcc
            // 
            this.btn_addAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_addAcc.FlatAppearance.BorderSize = 0;
            this.btn_addAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addAcc.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAcc.ForeColor = System.Drawing.Color.White;
            this.btn_addAcc.Location = new System.Drawing.Point(80, 88);
            this.btn_addAcc.Name = "btn_addAcc";
            this.btn_addAcc.Size = new System.Drawing.Size(304, 93);
            this.btn_addAcc.TabIndex = 0;
            this.btn_addAcc.Text = "Add Account";
            this.btn_addAcc.UseVisualStyleBackColor = false;
            this.btn_addAcc.Click += new System.EventHandler(this.btn_addAcc_Click_1);
            // 
            // btn_delAcc
            // 
            this.btn_delAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_delAcc.FlatAppearance.BorderSize = 0;
            this.btn_delAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delAcc.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delAcc.ForeColor = System.Drawing.Color.White;
            this.btn_delAcc.Location = new System.Drawing.Point(80, 263);
            this.btn_delAcc.Name = "btn_delAcc";
            this.btn_delAcc.Size = new System.Drawing.Size(304, 93);
            this.btn_delAcc.TabIndex = 2;
            this.btn_delAcc.Text = "Delete Account";
            this.btn_delAcc.UseVisualStyleBackColor = false;
            this.btn_delAcc.Click += new System.EventHandler(this.btn_delAcc_Click);
            // 
            // adminViewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminViewAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminViewAcc";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.adminViewAcc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addAcc;
        private System.Windows.Forms.Button btn_delAcc;
    }
}