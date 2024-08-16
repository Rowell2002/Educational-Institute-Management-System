namespace finalproject
{
    partial class adminClsSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminClsSchedule));
            this.cls_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addStSchedule = new System.Windows.Forms.Button();
            this.btn_updateStSchedule = new System.Windows.Forms.Button();
            this.cls_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cls_pnl
            // 
            this.cls_pnl.Controls.Add(this.panel2);
            this.cls_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cls_pnl.Location = new System.Drawing.Point(0, 0);
            this.cls_pnl.Name = "cls_pnl";
            this.cls_pnl.Size = new System.Drawing.Size(1093, 622);
            this.cls_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_addStSchedule);
            this.panel2.Controls.Add(this.btn_updateStSchedule);
            this.panel2.Location = new System.Drawing.Point(323, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 448);
            this.panel2.TabIndex = 21;
            // 
            // btn_addStSchedule
            // 
            this.btn_addStSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_addStSchedule.FlatAppearance.BorderSize = 0;
            this.btn_addStSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStSchedule.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addStSchedule.ForeColor = System.Drawing.Color.White;
            this.btn_addStSchedule.Location = new System.Drawing.Point(80, 82);
            this.btn_addStSchedule.Name = "btn_addStSchedule";
            this.btn_addStSchedule.Size = new System.Drawing.Size(304, 110);
            this.btn_addStSchedule.TabIndex = 0;
            this.btn_addStSchedule.Text = "Add Class Schedule";
            this.btn_addStSchedule.UseVisualStyleBackColor = false;
            this.btn_addStSchedule.Click += new System.EventHandler(this.btn_addStSchedule_Click_1);
            // 
            // btn_updateStSchedule
            // 
            this.btn_updateStSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_updateStSchedule.FlatAppearance.BorderSize = 0;
            this.btn_updateStSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStSchedule.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStSchedule.ForeColor = System.Drawing.Color.White;
            this.btn_updateStSchedule.Location = new System.Drawing.Point(80, 258);
            this.btn_updateStSchedule.Name = "btn_updateStSchedule";
            this.btn_updateStSchedule.Size = new System.Drawing.Size(304, 110);
            this.btn_updateStSchedule.TabIndex = 2;
            this.btn_updateStSchedule.Text = "Update Class Schedule";
            this.btn_updateStSchedule.UseVisualStyleBackColor = false;
            this.btn_updateStSchedule.Click += new System.EventHandler(this.btn_updateStSchedule_Click);
            // 
            // adminClsSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.cls_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminClsSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminClsSchedule";
            this.Load += new System.EventHandler(this.adminClsSchedule_Load);
            this.cls_pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cls_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addStSchedule;
        private System.Windows.Forms.Button btn_updateStSchedule;
    }
}