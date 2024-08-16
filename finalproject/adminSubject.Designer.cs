namespace finalproject
{
    partial class adminSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminSubject));
            this.sub_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addSub = new System.Windows.Forms.Button();
            this.btn_DelSub = new System.Windows.Forms.Button();
            this.sub_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sub_pnl
            // 
            this.sub_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sub_pnl.BackgroundImage")));
            this.sub_pnl.Controls.Add(this.panel2);
            this.sub_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_pnl.Location = new System.Drawing.Point(0, 0);
            this.sub_pnl.Name = "sub_pnl";
            this.sub_pnl.Size = new System.Drawing.Size(1093, 622);
            this.sub_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_addSub);
            this.panel2.Controls.Add(this.btn_DelSub);
            this.panel2.Location = new System.Drawing.Point(350, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 448);
            this.panel2.TabIndex = 22;
            // 
            // btn_addSub
            // 
            this.btn_addSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_addSub.FlatAppearance.BorderSize = 0;
            this.btn_addSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSub.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSub.ForeColor = System.Drawing.Color.White;
            this.btn_addSub.Location = new System.Drawing.Point(80, 82);
            this.btn_addSub.Name = "btn_addSub";
            this.btn_addSub.Size = new System.Drawing.Size(304, 110);
            this.btn_addSub.TabIndex = 0;
            this.btn_addSub.Text = "Add Subject";
            this.btn_addSub.UseVisualStyleBackColor = false;
            this.btn_addSub.Click += new System.EventHandler(this.btn_addSub_Click);
            // 
            // btn_DelSub
            // 
            this.btn_DelSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_DelSub.FlatAppearance.BorderSize = 0;
            this.btn_DelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelSub.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelSub.ForeColor = System.Drawing.Color.White;
            this.btn_DelSub.Location = new System.Drawing.Point(80, 258);
            this.btn_DelSub.Name = "btn_DelSub";
            this.btn_DelSub.Size = new System.Drawing.Size(304, 110);
            this.btn_DelSub.TabIndex = 2;
            this.btn_DelSub.Text = "Delete Subject";
            this.btn_DelSub.UseVisualStyleBackColor = false;
            this.btn_DelSub.Click += new System.EventHandler(this.btn_DelSub_Click);
            // 
            // adminSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.sub_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admincSubject";
            this.Load += new System.EventHandler(this.admincSubject_Load);
            this.sub_pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sub_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addSub;
        private System.Windows.Forms.Button btn_DelSub;
    }
}